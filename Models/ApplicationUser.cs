using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_e_commerce.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Address { get; set; }

        public string City { get; set; }
        [NotMapped]
        public string Fullname
        {
            get
            {
                return Name + " " + Surname;
            }
        }
    }
}