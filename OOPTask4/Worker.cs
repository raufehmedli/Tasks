using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask4
{
    internal class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double Salary { get; set; }
        public Worker(int id, string name, string lastname, double salary)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Salary = salary;
        }

        public string GetFullInfo()
        {
            return $"{Name} {Lastname}";
        }
    }
}
