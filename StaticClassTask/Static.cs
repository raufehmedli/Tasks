using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassTask
{
    static internal class Static
    {
        public static string Name { get; set; }

        public static string Extention(this string name)
        {
            return name + " " + "muellim";
            
        }
    }
}
