using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabxanaTask
{
    internal class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }

        List<Book> Books =new List<Book>();
        public Library(int id, string name, int capacity)
        {
            Id = id;
            Name = name;
            Capacity = capacity;
        }
        public void OrderBook(Book book)
        {
            if (Capacity > Books.Count)
            {
                Books.Add(book);
                Console.WriteLine(@$"Secdiyiniz kitabin adi :{book.name}
Sifaris ugurla tamamlandi");
                Capacity--;
            }
            else if (Capacity == Books.Count)
            {
                Books.Add(book);
                Console.WriteLine(@$"Secdiyiniz kitabin adi :{book.name}
Sifaris ugurla tamamlandi
Stokdaki sonuncu kitabi elde etdiniz");
                Capacity--;
            }
            else
            {
                Console.WriteLine("Stokda kitab yoxdur");
            }
        }
        public void RefundBook(Book book)
        {
                Books.Remove(book);
                Console.WriteLine(@$"Secdiyiniz kitabin adi :{book.name} 
Sifarisiniz geri qaytarildi");
                Capacity++;
        }
        public string Status()
        {
            return $"Stokda {Capacity} kitab qalib";
        }
    }
}
