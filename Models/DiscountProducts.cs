using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_e_commerce.Models
{
    public class DiscountProducts
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product{ get; set; }

        public double Rate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public bool OtherOffers { get; set; } = true;
    }
}
