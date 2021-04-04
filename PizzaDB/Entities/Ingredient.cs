#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Ingredient.cs
// 
// Current Data:
// 2021-04-05 2:08 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaDB.Entities.Types;

namespace PizzaDB.Entities
{
  public class Ingredient
  {
    public int IngredientId { get; set; }

    [MaxLength(25)] public string IngredientName { get; set; }

    public IngredientType IngredientType { get; set; }

    public ICollection<StockTake> StockTakes { get; set; } = new HashSet<StockTake>();
    public ICollection<MenuItem> MenuItems { get; set; } = new HashSet<MenuItem>();
    public ICollection<Supplier> IngredientSuppliers { get; set; } = new HashSet<Supplier>();
  }
}