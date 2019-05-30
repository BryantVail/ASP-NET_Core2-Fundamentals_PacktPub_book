

using System.Collections.Generic;

namespace Lesson4_Models.Models
{
    public class Order
    {
        public List<Product>    Products { get; set; }
        public decimal          Total { get; set; }
        public int              OrderId { get; set; }
        public decimal          Discount => Total > 1000M ? Total * .1M : Total; 

    }
}