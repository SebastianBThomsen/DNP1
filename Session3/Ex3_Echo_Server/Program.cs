using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Ex3_Echo_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Server..");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();

            Console.WriteLine("Server Started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();

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
}