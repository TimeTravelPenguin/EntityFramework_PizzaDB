using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int DiscountId { get; set; }

        public Discount Discount { get; set; }

        public double DiscountPercentage { get; set; }

        public double PaymentSubTotal { get; set; }

        public double PaymentTax { get; set; }

        public double PaymentTotal { get; set; }

        [Required]
        public DateTime DateTimeOrderPlaced { get; set; }

        [Required]
        public DateTime DateTimeOrderDue { get; set; }

        public DateTime? DateTimeOrderFulfilled { get; set; }
    }
}