#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Ingredient.cs
// 
// Current Data:
// 2021-04-02 9:32 PM
// 
// Creation Date:
// -- 

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [MaxLength(25)]
        public string Name { get; set; }

        public Stock Stock { get; set; }
        public IngredientType IngredientType { get; set; }

        public ICollection<StockTake> StockTakes { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}