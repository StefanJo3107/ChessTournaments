using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Common.Communication;
using Common.Domain;

namespace Server
{
    public class ClientHandler
    {
        private Sender sender;
        private Receiver receiver;
        private Socket socket;
        private Action<string> LogInfo;
        private Action<string> LogTrace;

        public ClientHandler(Socket socket, Action<string> LogInfo, Action<String> LogTrace)
        {
            this.socket = socket;
            this.LogInfo = LogInfo;
            this.LogTrace = LogTrace;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void HandleRequest()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    (Response r, bool endConnection) = ProcessRequest(req);
                    sender.Send(r);

                    if (endConnection)
                    {
                        sender.Stop();
                        receiver.Stop();
                        socket.Close();
                        LogInfo("Klijent se diskonektovao");
                        return;
                    }
                }
            }
            catch (ThreadAbortException)
            {
                sender.Stop();
                receiver.Stop();
                socket.Close();
            }
        }

        private (Response, bool) ProcessRequest(Request req)
        {
            Response r = new Response();
            bool endConnection = false;
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        var user = (User)req.Argument;
                        if (!Session.activeUsers.Contains(user))
                        {
                            r.Result = Controller.Instance.Login((User)req.Argument);
                            if (r.Result != null)
                                Session.activeUsers.Add(user);
                        }
                        else
                        {
                            r.Result = null;
                        }
                        break;
                    case Operation.Register:
                        r.Result = Controller.Instance.Register((User)req.Argument);
                        break;
                    case Operation.Disconnect:
                        Session.activeUsers.Remove((User)req.Argument);
                        r.Result = true;
                        endConnection = true;
                        break;
                    case Operation.GetTournaments:
                        r.Result = Controller.Instance.GetAllTournaments();
                        break;
                    case Operation.GetPlayers:
                        r.Result = Controller.Instance.GetAllPlayers();
                        break;
                    case Operation.GetLocations:
                        r.Result = Controller.Instance.GetAllLocations();
                        break;
                    case Operation.GetTournamentTypes:
                        r.Result = Controller.Instance.GetAllTournamentTypes();
                        break;
                    case Operation.CreateTournament:
                        r.Result = Controller.Instance.CreateTournament((Tournament)req.Argument);
                        break;
                    case Operation.EditTournament:
                        r.Result = Controller.Instance.EditTournament((Tournament)req.Argument);
                        break;
                    case Operation.CreatePlayer:
                        r.Result = Controller.Instance.CreatePlayer((Player)req.Argument);
                        break;
                    case Operation.EditPlayer:
                        r.Result = Controller.Instance.EditPlayer((Player)req.Argument);
                        break;
                    case Operation.GetGames:
                        r.Result = Controller.Instance.GetAllGames((Tournament)req.Argument);
                        break;
                    case Operation.SearchPlayers:
                        r.Result = Controller.Instance.SearchPlayers((string)req.Argument);
                        break;
                    case Operation.SearchTournaments:
                        r.Result = Controller.Instance.SearchTournaments((string)req.Argument);
                        break;
                    case Operation.DeleteTournament:
                        r.Result = Controller.Instance.DeleteTournament((Tournament)req.Argument);
                        break;
                    case Operation.CreateGames:
                        r.Result = Controller.Instance.CreateGames((List<Game>)req.Argument);
                        break;
                    case Operation.EditGames:
                        r.Result = Controller.Instance.EditGames((List<Game>)req.Argument);
                        break;
                }
            }
            catch (Exception ex)
            {
                r.Exception = ex;
                Debug.WriteLine(ex.Message);
            }
            return (r, endConnection);
        }
    }
}
