using System;
using System.Net.Sockets;
using System.Text;

namespace Ex4_MultiThreaded_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Client..");

            TcpClient client = new TcpClient("127.0.0.1", 5000);

            NetworkStream stream = client.GetStream();
            
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
    }
}