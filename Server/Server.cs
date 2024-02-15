using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace Server
{
    internal class Server
    {
        Socket socket;
        static Server _instance;
        public Action<string> LogInfo;
        public Action<string> LogTrace;
        public List<Thread> clientThreads = new List<Thread>();
        Thread serverThread;

        public static Server Instance { 
            get { 
                if (_instance == null) 
                    _instance = new Server(); 
                return _instance; } 
        }

        public void Start()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));

            socket.Bind(endPoint);
            socket.Listen(5);

            serverThread = new Thread(AcceptClient);
            serverThread.Start();
            LogInfo("---------- Server je pokrenut ----------");

        }

        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    ClientHandler handler = new ClientHandler(clientSocket, LogInfo, LogTrace);
                    Thread clientThread = new Thread(handler.HandleRequest);
                    clientThread.Start();
                    clientThreads.Add(clientThread);
                    LogInfo("Novi klijent se povezao");
                }
            }
            catch (Exception ex)
            {
                LogTrace($"---------- {ex.Message} ----------");
            }
        }


        public void Stop()
        {
            foreach(Thread t in clientThreads)
            {
                t.Abort();
            }
            socket.Close();
            serverThread.Abort();
            LogInfo("---------- Server je zaustavljen ----------");
        }

    }
}
