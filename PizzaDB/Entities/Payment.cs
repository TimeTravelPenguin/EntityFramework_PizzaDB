#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Payment.cs
// 
// Current Data:
// 2021-04-05 8:53 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Payments")]
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
  }
}