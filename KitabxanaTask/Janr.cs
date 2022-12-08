using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabxanaTask
{
    internal class Janr
    {
       public int Id { get; set; }
       public string Name { get; set; }
        List<Book> books = new List<Book>();
        public Janr(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }
        public string Status()
        {
            return $"{Name} janrda olan kitablarin sayi :{books.Count} ";
        }
    }
}
