#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Customer.cs
// 
// Current Data:
// 2021-04-05 8:49 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Customers")]
  public class Customer
  {
    public int CustomerId { get; set; }

    [Required] [MaxLength(25)] public string FirstName { get; set; }

    [Required] [MaxLength(25)] public string LastName { get; set; }
  }
}