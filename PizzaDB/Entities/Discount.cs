#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Discount.cs
// 
// Current Data:
// 2021-04-03 5:38 PM
// 
// Creation Date:
// -- 

#endregion

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PizzaDB.Entities
{
  [Index(nameof(DiscountCode), IsUnique = true)]
  public class Discount
  {
    public int DiscountId { get; set; }

    public int DiscountCode { get; set; }

    [Required] [MaxLength(200)] public string Description { get; set; }
  }
}