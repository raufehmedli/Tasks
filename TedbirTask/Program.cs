using System;

namespace TedbirTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hall hall1 = new Hall(1, "Hall A", 5, 5);
            hall1.OrderTicket(1, "Araz", "Merdanov", "IT CLUB", new DateTime(2022, 12, 07, 16, 0, 0), new DateTime(2022, 12, 07, 18, 0, 0), 3, 3);
            hall1.OrderTicket(2, "Rauf", "Ehmedli", "IT CLUB", new DateTime(2022, 12, 07, 16, 0, 0), new DateTime(2022, 12, 07, 18, 0, 0), 3, 5);
            hall1.GetStatus();
            hall1.UpdateTicket(1, 3, 4);
            hall1.OrderTicket(3, "Huseyn", "Huseynov", "IT CLUB", new DateTime(2022, 12, 07, 16, 0, 0), new DateTime(2022, 12, 07, 18, 0, 0), 3, 5);

            hall1.GetStatus();

        }
    }
}