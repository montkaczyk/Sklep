using System.ComponentModel.DataAnnotations;

namespace sklep.Models
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Range(0.01, 10000)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Range(0, 1000)]
        [Display(Name = "Stock Quantity")]
        public int StockQuantity { get; set; }
    }
}
