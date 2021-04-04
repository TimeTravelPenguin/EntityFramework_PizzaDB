#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Contact.cs
// 
// Current Data:
// 2021-04-05 8:49 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PizzaDB.Entities
{
  [Table("Contacts")]
  public class Contact
  {
    public int ContactId { get; set; }

    [Required] [MaxLength(30)] public string ContactName { get; set; }

    [Required]
    [MaxLength(10)]
    [Comment("AUS contact number in form: 0123 456 789")]
    public string ContactNumber { get; set; }
  }
}