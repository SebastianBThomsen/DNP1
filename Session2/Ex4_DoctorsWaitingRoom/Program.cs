using System;

namespace Ex4_DoctorsWaitingRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            WaitingRoom waitingRoom = new();
            Patient patient1 = new(waitingRoom);
            Patient patient2 = new(waitingRoom);
            Patient patient3 = new(waitingRoom);

            waitingRoom.RunWaitingRoom();
        }
    }
}