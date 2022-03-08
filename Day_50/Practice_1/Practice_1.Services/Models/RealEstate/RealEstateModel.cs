using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.Services.Models
{
    public class RealEstateModel
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public int Price { get; set; }
        public string Owner { get; set; }
    }
}
