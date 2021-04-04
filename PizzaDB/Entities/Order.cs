#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Order.cs
// 
// Current Data:
// 2021-04-05 8:52 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Orders")]
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