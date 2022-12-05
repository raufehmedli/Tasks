using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPtask
{
    internal class Car: Vehicle
    {
        public Car(string car_name, string car_capacity, string car_speed) : base (car_name, car_capacity, car_speed)
        {
            this.Name = car_name;
            this.Capacity= car_capacity;
            this.Speed=car_speed;
        }
        public string getfullinfo()
        {
            return $"{Name} {Capacity} {Speed}";
        }
    }
}
