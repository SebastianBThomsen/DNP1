using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Chat_Program_Client
{
    public class ClientSocketHandler
    {
        public void Run(TcpClient client)
        {
            NetworkStream stream = client.GetStream();

            new Thread(() => ListenToServer());
            
            string s = "";
            while (!s.Equals("exit"))
            {
                Console.WriteLine("Input text to server");
                s = Console.ReadLine();

                byte[] dataToServer = Encoding.ASCII.GetBytes(s);
                stream.Write(dataToServer, 0, dataToServer.Length);

                byte[] dataFromServer = new byte[1024];
                int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
                string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
                Console.WriteLine(response);
            }

            stream.Close();
            client.Close();
        }

        public void ListenToServer()
        {
            string message = "";
            
            while (true)
            {
                Console.WriteLine(message);
            }
        }
    }
}