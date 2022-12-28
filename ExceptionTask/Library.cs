using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    internal class Library
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Library(string name)
        {
            Name = name;
            Users = new List<User>();
        }
    }
}
