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
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzaDB.Entities
{
  [Table("StockTakes`")]
  [Index(nameof(IngredientId), IsUnique = true)]
  public class StockTake
  {
    public int StockTakeId { get; set; }

    [Required] public int IngredientId { get; set; }

    public Ingredient Ingredient { get; set; }

    [Required] public DateTime DateTime { get; set; }

    public int StockLevel { get; set; }
  }
}