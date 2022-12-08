using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabxanaTask
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        List<Book> books = new List<Book>();

        public Author(int id, string name,string lastname)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
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
            return $"Yazici : {Lastname} {Name}, kitablarinin sayi :{books.Count} ";
        }
    }
}
