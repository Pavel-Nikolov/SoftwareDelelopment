using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Brand()
        {

        }
    }
}
