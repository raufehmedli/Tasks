namespace StaticClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string abc = "Rauf";
            string a = "Araz";
            Console.WriteLine(abc.Extention());
            Console.WriteLine(a.Extention());
            Console.WriteLine(Static.Extention("Sadiq"));

        }
    }
}