using System;
using System.Threading;

namespace Ex4_DoctorsWaitingRoom
{
    public class WaitingRoom
    {
        public Action<int> NumberChange { get; set; }
        private int currentNumber = 0;
        private int ticketCount = 0;

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                Console.WriteLine("\nDING");
                Console.WriteLine($"Patient number {++currentNumber} can now enter");
                NumberChange?.Invoke(currentNumber);
                Thread.Sleep(1000);
            }
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }
    }
}