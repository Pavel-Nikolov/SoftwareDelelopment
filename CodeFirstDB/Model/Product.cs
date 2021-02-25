using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Product
    {
        [Key]
        public string Barcode { get; set; }

        [Required]
        public string Name { get; set; }

        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public Brand Brand { get; set; }
        public ICollection<User> Users { get; set; }

        public Product()
        {

        }
    }
}