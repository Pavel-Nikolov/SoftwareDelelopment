using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Age { get; set; }
        public ICollection<Product> Products { get; set; }

        public User()
        {

        }
    }
}
