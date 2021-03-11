using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace StoreMVC.Models
{
    public class CustomerIndexVM
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        public string Email { get; set; }

        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
    }
}