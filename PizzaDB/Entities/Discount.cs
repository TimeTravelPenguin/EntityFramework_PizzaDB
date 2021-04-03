#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Discount.cs
// 
// Current Data:
// 2021-04-03 5:38 PM
// 
// Creation Date:
// -- 

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }

        [Index(IsUnique = true)]
        public int DiscountCode { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
    }
}