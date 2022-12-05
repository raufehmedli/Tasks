using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TedbirTask
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Tedbir { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
    }
}
