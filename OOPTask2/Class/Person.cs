using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2.Class
{
    internal class Person
    {
        private int _id;
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Id { get { return _id; } set { _id = value; } }

        public Person(int id, string name, string lastname)
        {
            _id = id;
            Name = name;
            LastName = lastname;
        }
        public virtual string GetFullInfo()
        {
            return $"{Name} {LastName}";
        }
    }
}
