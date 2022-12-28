using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTask
{
    internal class User
    {
        public static int Id { get; set; }
        public int _id;
        public string Name { get; set; }
        public string Email { get; set; }

        public User( string name)
        {
            Id++;
            _id = Id;
            Name = name;
        }
        public void Emailcheck()
        {
            List<User> users = new List<User>();
        }
    }
}
