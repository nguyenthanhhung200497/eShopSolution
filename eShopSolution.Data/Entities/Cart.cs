using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int Id { get;set; }
        public int ProductId { get; set; }
        public int Quatity { get; set; }
        public decimal Price { get; set; }
        public DateTime DataCreated { get; set; }
        public Product Product { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
