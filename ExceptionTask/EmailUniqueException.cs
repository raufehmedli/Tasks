
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    internal class EmailUniqueException:Exception
    {
        public EmailUniqueException(string message) : base(message)
        {

        }
    }
}
