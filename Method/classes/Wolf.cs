using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.classes
{
    internal class Wolf:Animal
    {
        public Wolf(string name) : base(name)
        {
            canSwim = false;
        }
    }
}
