using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greenlife_organic_system.Models
{
    public class Customer : User
    {
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customer()
        {
        }

        public string Role => "Customer";
    }
}
