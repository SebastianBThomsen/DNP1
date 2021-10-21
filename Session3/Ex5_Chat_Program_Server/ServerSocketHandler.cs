using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Ex5_Chat_Program_Server
{
    public class ServerSocketHandler
    {
        public TcpClient Client;
        private NetworkStream stream;
        public Action<string> SubscribeToMessage;

        public ServerSocketHandler(TcpClient client)
        {
            Console.WriteLine("Client connected");
            stream = client.GetStream();
            Client = client;
        }
        

        public void Run()
        {

            bool isTrue = true;
            while (isTrue)
            {
                // read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);
                SubscribeToMessage?.Invoke(s);
                if (s.Equals("exit"))
                    isTrue = false;

                //respond
                byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                stream.Write(dataToClient, 0, dataToClient.Length);
            }

            Console.WriteLine("False - Inspect");
            //close connection
            Client.Close();
            
        }
    }
}