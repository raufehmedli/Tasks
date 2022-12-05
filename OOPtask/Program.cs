namespace OOPtask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("BMW","150","30");
            Console.WriteLine(car1.getfullinfo());
            Bus bus1 = new Bus("Sprinter","120","40");
            Console.WriteLine(bus1.getfullinfo());
        }
    }
}