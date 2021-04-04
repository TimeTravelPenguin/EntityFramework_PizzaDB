#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: BankAccount.cs
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
  [Table("BankAccounts")]
  public class BankAccount
  {
    public int BankAccountId { get; set; }

    [Required] public int BankId { get; set; }

    public Bank Bank { get; set; }

    [Required] [MaxLength(20)] public string AccountNumber { get; set; }
  }
}