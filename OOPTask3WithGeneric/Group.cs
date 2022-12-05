using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask3WithGeneric
{
    internal class Group
    {
        public int Id;
        public string Name { get; set; }
        public Group(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
