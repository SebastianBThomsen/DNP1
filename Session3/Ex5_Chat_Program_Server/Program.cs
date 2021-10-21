namespace Ex5_Chat_Program_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServerSocket serverSocket = new();
            serverSocket.Start();
        }
    }
}