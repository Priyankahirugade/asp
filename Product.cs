using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="product name required")]
        [DisplayName("product Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "price is required")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Qty is required")]
        public int Qty { get; set; }

        public string Remarks { get; set; }

    }

    public class EFCodeFirstEntity : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}