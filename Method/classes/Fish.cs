using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.classes
{
    internal class Fish : Animal
    {
        public Fish(string name) : base(name)
        {
            this.canSwim = true;
        }

    }
}
