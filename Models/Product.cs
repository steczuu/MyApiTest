using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class Product
    {
        public int product_id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        public float price { get; set; }
    }
}
