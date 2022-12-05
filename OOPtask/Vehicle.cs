using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask
{
    internal class Vehicle
    {
        private string _id;
        public string Name { get; set; }
        public string Speed {get; set; }
        public string Capacity {get; set; }

        public Vehicle(string name, string speed, string capacity)
        {
            Name = name;
            Speed = speed;
            Capacity = capacity;
        } 
    }
}
