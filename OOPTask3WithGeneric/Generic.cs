using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTask3WithGeneric
{
    internal class Generic<T,U> where T:U
    {
        public U[] values = { };
        public void AddElement(U value)
        {
            Array.Resize(ref values, values.Length + 1);
            values[values.Length - 1] = value;
        }

        public void RemoveElement(U value)
        {
            U[] newArr = { };
            foreach (var n in values)
            {
                if (!n.Equals(value))
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = n;
                }
            }
            values = newArr;
        }

    }
}
