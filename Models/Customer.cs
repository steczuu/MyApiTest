using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    [PrimaryKey(nameof(customer_id))]   
    public class Customer
    {
        public int customer_id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string email { get; set; }
    }
}
