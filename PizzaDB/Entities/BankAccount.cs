#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: BankAccount.cs
// 
// Current Data:
// 2021-04-05 2:07 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
  public class BankAccount
  {
    public int BankAccountId { get; set; }

    [Required] public int BankId { get; set; }

    public Bank Bank { get; set; }

    [Required] [MaxLength(20)] public string AccountNumber { get; set; }
  }
}