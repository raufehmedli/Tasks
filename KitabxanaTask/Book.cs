using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitabxanaTask
{
    internal class Book
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int Page { get; set; }
        List<Author> authors=new List<Author>();
        List<Janr> janrs=new List<Janr>();
        List<Library> libraries=new List<Library>();

        public Book(int id, string name, int page)
        {
            Id = id;
            this.name = name;
            Page = page;
        }
    }
}
