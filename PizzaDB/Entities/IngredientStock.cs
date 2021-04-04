#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: IngredientStock.cs
// 
// Current Data:
// 2021-04-05 8:52 AM
// 
// Creation Date:
// 2021-04-04 4:32 PM

#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("IngredientStocks")]
  public class IngredientStock
  {
    public int IngredientStockId { get; set; }

    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }

    public int CurrentStockLevel { get; set; }
    public int RecommendedStockLevel { get; set; }
    public int ReorderStockLevel { get; set; }
  }
}