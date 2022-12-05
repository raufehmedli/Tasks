using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Student
    {
        public static int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public List<Group> groups;
        public Student( string name)
        {
            Id++;
            Name = name;
        }
    }
}
