using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
  public class Order
  {
    public int OrderId { get; set; }

    [Required] public int PaymentId { get; set; }

    public Payment Payment { get; set; }


    [Required] public DateTime DateTimeOrderPlaced { get; set; }

    [Required] public DateTime DateTimeOrderDue { get; set; }

    public DateTime? DateTimeOrderFulfilled { get; set; }
  }
}