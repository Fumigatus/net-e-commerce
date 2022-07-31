using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_e_commerce.Models
{
    public class SpecialOffer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double DiscountRate { get; set; }

        public double Minimum { get; set; }
    }
}
