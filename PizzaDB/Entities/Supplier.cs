#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Supplier.cs
// 
// Current Data:
// 2021-04-05 2:09 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
  public class Supplier
  {
    public int SupplierId { get; set; }

    [MaxLength(50)] public string Name { get; set; }

    public ICollection<Ingredient> SuppliedIngredients { get; set; } = new List<Ingredient>();
  }
}