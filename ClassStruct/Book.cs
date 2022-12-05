using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    internal class Book
    {
        public Book(string name, string author, int pages)
        {
            Name = name;
            Author = author;
            Pages = pages;
        }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }

    }
    struct dordbucaq
    {
        public int widht { get; set; }
        public int height { get; set; }

        public dordbucaq(int Widht, int Height)
        {
            this.widht = Widht;
            this.height = Height;
        }
        public int area()
        {
            return widht * height;
        }
    }
}
