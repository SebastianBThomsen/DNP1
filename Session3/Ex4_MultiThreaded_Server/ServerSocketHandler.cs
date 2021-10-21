using System;
using System.Net.Sockets;
using System.Text;

namespace Ex4_MultiThreaded_Server
{
    public class ServerSocketHandler
    {
        public void Run(TcpClient client)
        {
            Console.WriteLine("Client connected");
            NetworkStream stream = client.GetStream();

            bool isTrue = true;
            while (isTrue)
            {
                // read
                byte[] dataFromClient = new byte[1024];
                int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
                string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
                Console.WriteLine(s);
                if (s.Equals("exit"))
                    isTrue = false;

                //respond
                byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
                stream.Write(dataToClient, 0, dataToClient.Length);
            }

            Console.WriteLine("False - Inspect");
            //close connection
            client.Close();
            
        }
    }
}