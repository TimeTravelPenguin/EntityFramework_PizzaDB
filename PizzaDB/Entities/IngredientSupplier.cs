#region Title Header
// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: IngredientSupplier.cs
// 
// Current Data:
// 2021-04-05 9:25 AM
// 
// Creation Date:
// 2021-04-05 9:25 AM
#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("IngredientSuppliers")]
  public class IngredientSupplier
  {
    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
  }
}