using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Ex5_Chat_Program_Client
{
    public class ClientSocket
    {
        public void Start()
        {
            Console.WriteLine("Starting Client..");

            while (true)
            {
                TcpClient client = new TcpClient("127.0.0.1", 5000);

            }
            
            
            Thread thread = new Thread(start: run => new ClientSocketHandler());
            thread.Start();
        }
    }
}