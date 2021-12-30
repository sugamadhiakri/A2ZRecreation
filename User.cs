using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2ZRecreation
{
    public enum UserType
    {
        ADMIN,
        STAFF
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
    }
}
