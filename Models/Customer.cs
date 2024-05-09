using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class Customer
    {
        public int customer_id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string email { get; set; }
    }
}
