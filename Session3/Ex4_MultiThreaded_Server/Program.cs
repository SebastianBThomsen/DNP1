using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex4_MultiThreaded_Server
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
                ServerSocketHandler socketHandler = new();
                Thread thread = new Thread(() => socketHandler.Run(client));
                thread.Start();
            }
        }
    }
}