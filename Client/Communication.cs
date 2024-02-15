using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Common.Communication;
using Common.Domain;

namespace Client
{
    public class Communication
    {
        private static Communication _instance;
        public static Communication Instance
        {
            get
            {
                if (_instance == null) _instance = new Communication();
                return _instance;
            }
        }

        Socket socket;
        Sender sender;
        Receiver receiver;

        private Communication()
        {

        }

        public void Connect()
        {
            while (true)
            {
                try
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    socket.Connect(ConfigurationManager.AppSettings["ip"], int.Parse(ConfigurationManager.AppSettings["port"]));
                    sender = new Sender(socket);
                    receiver = new Receiver(socket);
                    break;
                }
                catch (Exception)
                {

                }
            }
        }

        public void Stop()
        {
            sender.Stop();
            receiver.Stop();
        }

        internal Response Login(User user)
        {
            Request req = new Request
            {
                Argument = user,
                Operation = Operation.Login
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response Register(User user)
        {
            Request req = new Request
            {
                Argument = user,
                Operation = Operation.Register
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response Disconnect()
        {
            Request req = new Request
            {
                Argument = Session.activeUser,
                Operation = Operation.Disconnect
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetAllTournaments()
        {
            Request req = new Request
            {
                Argument = null,
                Operation = Operation.GetTournaments
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetAllPlayers()
        {
            Request req = new Request
            {
                Argument = null,
                Operation = Operation.GetPlayers
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetAllLocations()
        {
            Request req = new Request
            {
                Argument = null,
                Operation = Operation.GetLocations
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetAllTournamentTypes()
        {
            Request req = new Request
            {
                Argument = null,
                Operation = Operation.GetTournamentTypes
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response CreateTournament(Tournament tournament)
        {
            Request req = new Request
            {
                Argument = tournament,
                Operation = Operation.CreateTournament
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response EditTournament(Tournament tournament)
        {
            Request req = new Request
            {
                Argument = tournament,
                Operation = Operation.EditTournament
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response CreatePlayer(Player player)
        {
            Request req = new Request
            {
                Argument = player,
                Operation = Operation.CreatePlayer
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response EditPlayer(Player player)
        {
            Request req = new Request
            {
                Argument = player,
                Operation = Operation.EditPlayer
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response GetAllGames(Tournament tournament)
        {
            Request req = new Request
            {
                Argument = tournament,
                Operation = Operation.GetGames
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response SearchPlayers(string search)
        {
            Request req = new Request
            {
                Argument = search,
                Operation = Operation.SearchPlayers
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response SearchTournaments(string search)
        {
            Request req = new Request
            {
                Argument = search,
                Operation = Operation.SearchTournaments
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response DeleteTournament(Tournament tournament)
        {
            Request req = new Request
            {
                Argument = tournament,
                Operation = Operation.DeleteTournament
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response CreateGames(List<Game> games)
        {
            Request req = new Request
            {
                Argument = games,
                Operation = Operation.CreateGames
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }

        internal Response EditGames(List<Game> games)
        {
            Request req = new Request
            {
                Argument = games,
                Operation = Operation.EditGames
            };
            sender.Send(req);
            Response response = (Response)receiver.Receive();
            return response;
        }
    }
}
