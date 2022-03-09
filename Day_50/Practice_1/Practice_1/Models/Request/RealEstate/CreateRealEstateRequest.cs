using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Models.Request.RealEstate
{
    public class CreateRealEstateRequest
    {
        public string Address { get; set; }

        public int Price { get; set; }
        public string Owner { get; set; }

        public string Identifier { get; set; }
    }
}
