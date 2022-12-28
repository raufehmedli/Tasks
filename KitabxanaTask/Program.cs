using Microsoft.VisualBasic;

namespace KitabxanaTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library(1, "Merkezi Kitabxana", 2);
            Book book1 = new Book(1, "C#", 300);
            Book book2 = new Book(1, "BackEnd Developer map", 300);
            Book book3 = new Book(1, "Sumqayit-Baki yolu", 300);
            Book book4 = new Book(1, "Nece bir anda Isler elde etdim", 300);

            Author author1 = new Author(1, "Rauf", "Ehmedli");
            Author author2 = new Author(1, "Sadiq", "Aliyev");

            Janr janr1 = new Janr(1, "Elmi");
            Janr janr2 = new Janr(1, "Bedii");
            author1.AddBook(book1);
            author1.AddBook(book3);
            author2.AddBook(book2);
            author2.AddBook(book4);
            janr1.AddBook(book1);
            janr1.AddBook(book2);
            janr2.AddBook(book3);
            janr2.AddBook(book4);
            Console.WriteLine(author1.Status());
            Console.WriteLine(author2.Status());
            Console.WriteLine(janr1.Status());
            Console.WriteLine(janr2.Status());
            library.OrderBook(book1);
            library.OrderBook(book4);
            library.OrderBook(book3);
            library.RefundBook(book1);
            Console.WriteLine(library.Status());
        }
    }
}