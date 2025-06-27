using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCodeFirst_Demo2.Entities
{
    internal class User
    {
        public int UserId { get; set; } // Primary Key
        public string UserName { get; set; } // User's name
        public string Email { get; set; } // User's email address
        public string Mobile { get; set; } // User's mobile number
        public string Password { get; set; } // User's password
    }
}
