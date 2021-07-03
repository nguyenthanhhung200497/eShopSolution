using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int Productd { get; set; }
        public int Quatity { get; set; }
        public decimal Price { get; set; }

    }
}
