using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask5
{
    internal class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Cinema(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Hall[] halls = { };
    }
}
