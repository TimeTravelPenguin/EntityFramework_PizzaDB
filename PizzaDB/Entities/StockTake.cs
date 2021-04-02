#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: StockTake.cs
// 
// Current Data:
// 2021-04-02 11:19 PM
// 
// Creation Date:
// -- 

#endregion

using System;
using System.Collections.Generic;

namespace PizzaDB.Entities
{
    public class StockTake
    {
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public DateTime DateTime { get; set; }
        public int StockLevel { get; set; }
    }
}