#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Supplier.cs
// 
// Current Data:
// 2021-04-05 9:44 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Suppliers")]
  public class Supplier
  {
    public int SupplierId { get; set; }

    [MaxLength(50)] public string Name { get; set; }
  }
}