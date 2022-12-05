using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        private string _id;
        public string Name { get; set; }
        public string Lastname { get; set; }

        public Person(string name, string lastname)
        {
            this.Name = name;
            this.Lastname = lastname;
        }
        public virtual string getfullname() /*Polymorphism*/
        {
            return $"{Name} {Lastname}";
        }
    }
}
