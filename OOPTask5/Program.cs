namespace OOPTask5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cinema May28 = new Cinema(1, "28 May");
            Cinema Genclik = new Cinema(2, "Genclik");
            Cinema Elmler = new Cinema(3, "Elmler");

            Hall hall1 = new Hall(1, "Hall 1", 10, 15, May28);
            Hall hall2 = new Hall(1, "Hall 2", 12, 16, May28);


            hall1.Place[3, 4] = true;
            hall1.Place[6, 5] = true;

            //hall1.OrderTicket(14314, "Rauf", "Ehmedli",(15,00),(17,00), 3,4) ;
            //hall1.OrderTicket(13465, "Araz", "Merdanov", 3, 4);


        }
    }
}