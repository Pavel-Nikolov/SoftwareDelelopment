using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
        public List<Product> FavoriteProducts { get; set; }
        public List<Product> RequestedProducts { get; set; }

        public User()
        {

        }
    }
}
