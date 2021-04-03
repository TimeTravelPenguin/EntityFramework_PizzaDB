using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        public int PaymentId { get; set; }

        public Payment Payment { get; set; }
    }
}