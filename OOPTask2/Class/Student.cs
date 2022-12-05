using OOPTask2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask2.Class
{
    internal class Student:Person,ILearn
    {
        public string GroupName { get; set; }

        public Student(int id,string name,string lastname,string groupname) :base(id,name,lastname)
        {
            GroupName = groupname;
        }
        public override string GetFullInfo()
        {
            return $"{Name} {LastName} {GroupName}";
        }

        public void Ilearn()
        {
            Console.WriteLine("I can learn");
        }
    }
}
