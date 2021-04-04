﻿using System.ComponentModel.DataAnnotations.Schema;

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