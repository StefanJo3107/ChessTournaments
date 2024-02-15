﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common.Communication
{
    public class Sender
    {

        private NetworkStream stream;
        private BinaryFormatter formatter;

        public Sender(Socket socket)
        {
            stream = new NetworkStream(socket);
            formatter = new BinaryFormatter();
        }

        public void Send(object argument)
        {
            try
            {
                formatter.Serialize(stream, argument);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Stop()
        {
            stream.Close();
        }

    }
}
