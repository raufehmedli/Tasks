namespace ClassStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Araz", "Araz", 200);
            Book book2 = new Book("Rauf", "Rauf", 250);
            Console.WriteLine(book1.Name);
            Console.WriteLine(book2.Pages);

            dordbucaq dordbucaq1 = new dordbucaq(15, 20);
            Console.WriteLine(dordbucaq1.area());

            Ucbucaq ucbucaq1 = new Ucbucaq(3, 4, 5);
            Ucbucaq ucbucaq2 = new Ucbucaq(5, 6, 7);
            Console.WriteLine(ucbucaq1.A);
            Console.WriteLine(ucbucaq2.B);
            Ucbucaq ucbucaq3 = new Ucbucaq(7, 8, 9);
            Console.WriteLine(ucbucaq3.per());

            Ucbucaqli ucbucaq4 = new Ucbucaqli(4, 5, 6);
            Console.WriteLine(ucbucaq4.perimetr());
        }

    }
}