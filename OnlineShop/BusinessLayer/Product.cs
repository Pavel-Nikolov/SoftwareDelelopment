using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public abstract class Product
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public ProductType ProductType { get; set; }
        public int Warranty { get; set; }
        public Brand Brand { get; set; }

        public Product()
        {

        }
    }
}
