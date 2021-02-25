using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Order
    {
        public int ID { get; set; }
        public User User { get; set; }
        public List<int> Quantities { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }

        public Order()
        {

        }
    }
}
