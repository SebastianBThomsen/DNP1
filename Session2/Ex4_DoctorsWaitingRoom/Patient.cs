using System;

namespace Ex4_DoctorsWaitingRoom
{
    public class Patient
    {
        private WaitingRoom room;
        private int numberInQueue;

        public Patient(WaitingRoom wr)
        {
            room = wr;
            room.NumberChange += ReactToNumber;
            numberInQueue = room.DrawNumber();
        }

        public void ReactToNumber(int ticketNumber)
        {
            Console.WriteLine($"Patient {numberInQueue} looks up");
            if (ticketNumber == numberInQueue)
            {
                Console.WriteLine("WOW IT*S MY TURN!");
                room.NumberChange -= ReactToNumber;
            }
            else
                Console.WriteLine("Gonna go back to my phone now! ;(");
        }
    }
}