using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask
{
    internal class Bus : Vehicle
    {

        public Bus(string bus_name, string bus_speed, string bus_capacity) : base(bus_name, bus_speed, bus_capacity)
        {
            this.Name = bus_name;
            this.Speed = bus_speed;
            this.Capacity = bus_capacity;
        }
        public string getfullinfo()
        {
            return $"{Name} {Speed} {Capacity}";
        }
    }
}
