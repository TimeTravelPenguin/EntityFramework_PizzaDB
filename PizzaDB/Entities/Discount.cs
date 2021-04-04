#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Discount.cs
// 
// Current Data:
// 2021-04-05 8:50 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzaDB.Entities
{
  [Table("Discounts")]
  [Index(nameof(DiscountCode), IsUnique = true)]
  public class Discount
  {
    public int DiscountId { get; set; }

    public int DiscountCode { get; set; }

    [Required] [MaxLength(200)] public string Description { get; set; }
  }
}