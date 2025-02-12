using System;
using System.Collections.Generic;

namespace sklep.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserModel User { get; set; }
        public List<ProductViewModel> Products { get; set; } = new List<ProductViewModel>();
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
