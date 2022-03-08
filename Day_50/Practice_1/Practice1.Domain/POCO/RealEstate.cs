using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1.Domain.POCO
{
    public class RealEstate
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Owner { get; set; }

        public int Price { get; set; }

        public string Identifier { get; set; }
    }
}
