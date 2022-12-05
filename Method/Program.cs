using Method.classes;

namespace Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            getname();
            Fish fish1 = new Fish("akula");
            Fish fish2 = new Fish("Akulaa");
            Console.WriteLine(fish2.CanSwim());
            Wolf wolf = new Wolf("Alpha");
            Console.WriteLine(wolf.CanSwim());
            Animal.AnimalCreate();
            Wolf.AnimalCreate();
            Fish.AnimalCreate();
            int a = int.Parse(Console.ReadLine());
            StaticClass.Name="Akula";
            a.Multiply(10);
        }
        static void getname()
        {
            Console.WriteLine("hello world");
        }
    }

}