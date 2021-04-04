#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Bank.cs
// 
// Current Data:
// 2021-04-05 8:48 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Banks")]
  public class Bank
  {
    public int BankId { get; set; }

    [Required] [StringLength(6)] public string Bsb { get; set; }

    [Required] [MaxLength(25)] public string BankName { get; set; }
  }
}