#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: IngredientStock.cs
// 
// Current Data:
// 2021-04-02 11:16 PM
// 
// Creation Date:
// -- 

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
    public class IngredientStock
    {
        public int IngredientStockId { get; set; }

        [Required]
        [ForeignKey(nameof(Entities.Ingredient.IngredientStock))]
        public ICollection<Ingredient> Ingredient { get; set; }

        public int CurrentStockLevel { get; set; }
        public int RecommendedStockLevel { get; set; }
        public int ReorderStockLevel { get; set; }
    }
}