#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Employee.cs
// 
// Current Data:
// 2021-04-05 8:59 AM
// 
// Creation Date:
// 2021-04-04 4:32 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("Employees")]
  public abstract class Employee
  {
    public int EmployeeId { get; set; }

    [Required] public int ContactId { get; set; }

    public Contact Contact { get; set; }

    [Required] public string FirstName { get; set; }

    [Required] public string LastName { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }

    [Required] [MaxLength(9)] public string TaxFileNumber { get; set; }

    [Required] public int BankAccountId { get; set; }

    public BankAccount BankAccount { get; set; }
  }
}