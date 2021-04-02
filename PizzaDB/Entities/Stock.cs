#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Stock.cs
// 
// Current Data:
// 2021-04-02 11:16 PM
// 
// Creation Date:
// -- 

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
    public class Stock
    {
        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }

        public int CurrentStockLevel { get; set; }
        public int RecommendedStockLevel { get; set; }
        public int ReorderStockLevel { get; set; }
    }
}