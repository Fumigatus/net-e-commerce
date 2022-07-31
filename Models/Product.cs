using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace net_e_commerce.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Range(1, int.MaxValue)]
        public double Price { get; set; }

        public double Quantity { get; set; }

        public Unit Unit { get; set; }

        public string Mint { get; set; }

        public string Desc { get; set; }

        public int? KategoriId { get; set; }
        [ForeignKey("KategoriId")]
        public Category Category { get; set; }

        public ICollection<Photo> Photo { get; set; }
    }

    public enum Unit
    {
        Adet,
        Kg,
        Litre,
        Kasa
    }
}
