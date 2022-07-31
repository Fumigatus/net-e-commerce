using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_e_commerce.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("UrunId")]
        public Product Product { get; set; }

        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public ApplicationUser ApplicationUser { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }

        public bool OrderOk { get; set; } = false;

        [NotMapped]
        public double Ucret
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
