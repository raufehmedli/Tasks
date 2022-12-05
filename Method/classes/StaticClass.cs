using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method.classes
{
    static internal class StaticClass
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        public static void Multiply(this int num, int num2)
        {
            Console.WriteLine(num + num2);
        }
    }
}
