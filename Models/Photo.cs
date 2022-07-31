using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_e_commerce.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string PhotoName { get; set; }

        public int? ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
