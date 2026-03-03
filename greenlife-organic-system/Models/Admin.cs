using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife_organic_system.Models
{
    public class Admin : User
    {
        public Admin()
        {
        }

        //  expression-bodied member: Only returns a value
        public string Role => "Admin";
    }
}
