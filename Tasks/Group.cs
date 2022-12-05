using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Group
    {
        public static int Id { get; set; }
        private int _id { get; set; }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name, int capacity)
        {
            Id++;
            _id = Id;
            Name = name;
            Capacity = capacity;
        }
        public void UpdateStudent(int id,string name="",string lastname="")
        {
            foreach (Student student in Students)
            {

            }
        }
    }
}

