#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: MenuItem.cs
// 
// Current Data:
// 2021-04-05 8:52 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("MenuItems")]
  public class MenuItem
  {
    public int MenuItemId { get; set; }

    [MaxLength(50)] public string Name { get; set; }

    public double SellPrice { get; set; }

    public ICollection<Ingredient> Ingredients { get; set; } = new HashSet<Ingredient>();
  }
}