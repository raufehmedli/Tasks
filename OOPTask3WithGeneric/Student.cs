using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask3WithGeneric
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Student(int id, string name)
        {
            Id = id;
            Name = name;

        }

    }
}
