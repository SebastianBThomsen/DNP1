using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Ex5_Chat_Program_Server
{
    public class ServerSocket
    {
        public void Start()
        {
            Console.WriteLine("Starting Server..");

            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 5000);
            listener.Start();

            Console.WriteLine("Server Started..");

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                
                ServerSocketHandler socketHandler = new(client);
                Thread thread = new Thread(() => socketHandler.Run());
                thread.Start();
            }
        }
    }
}