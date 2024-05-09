using System.ComponentModel.DataAnnotations.Schema;

namespace MyAPI.Models
{
    public class Transaction
    {
        public int transaction_id { get; set; }

        [ForeignKey(nameof(customer_id))]
        public int customer_id { get; set; }

        [ForeignKey(nameof(product_id))]
        public int product_id { get; set; }
        public int quantity { get; set; }
        public DateTime transaction_date { get; set; }
    }
}
