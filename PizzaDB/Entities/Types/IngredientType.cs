#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: IngredientType.cs
// 
// Current Data:
// 2021-04-03 12:21 AM
// 
// Creation Date:
// -- 

#endregion

using System;

namespace PizzaDB.Entities.Types
{
  [Flags]
  public enum IngredientType
  {
    Vegetable,
    Meat,
    Dairy,
    Vegan,
    Fruit
  }
}