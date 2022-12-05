using OOPTask2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2.Class
{
    internal class Teacher : Person,ITeach
    {
        public string Profession { get; set; }
        public Teacher(int id, string name, string lastname, string profession) : base(id, name, lastname)
        {
            Profession = profession;
        }
        public override string GetFullInfo()
        {
            return $"{Name} {LastName} {Profession}";
        }

        public void Iteach()
        {
            Console.WriteLine("I can teach");
        }
    }
}
