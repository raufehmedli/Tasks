using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.classes
{
    internal class Animal
    {
        public string Name { get; set; }
        protected bool canSwim;

        public Animal(string name)
        {
            this.Name = name;
        }
        public void Eat()
        {
            Console.WriteLine("Animal is eat");
        }
        public bool CanSwim()
        {
            return canSwim;
        }
        public static void AnimalCreate()
        {
            Console.WriteLine("Create");
        }
    }
}
