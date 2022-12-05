using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStruct
{
    internal class Ucbucaq
    {
        public Ucbucaq(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public int per()
        {
            return A + B + C;
        }

    }
    struct Ucbucaqli
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

        public Ucbucaqli(int A, int B, int C)
        {
            this.a = A;
            this.b = B;
            this.c = C;
        }
        public int perimetr()
        {
            return a + b + c;
        }
    }
}