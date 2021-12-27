using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Product { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public int CustomerID { get; set; }
    }
}
