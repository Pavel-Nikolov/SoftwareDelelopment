using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Brand
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }

        public Brand()
        {
        }
    }
}
