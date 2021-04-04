#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: MenuItemIngredient.cs
// 
// Current Data:
// 2021-04-05 8:52 AM
// 
// Creation Date:
// 2021-04-04 9:20 PM

#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("MenuItemIngredients")]
  public class MenuItemIngredient
  {
    public int MenuItemId { get; set; }
    public MenuItem MenuItem { get; set; }

    public int IngredientId { get; set; }
    public Ingredient Ingredient { get; set; }
  }
}