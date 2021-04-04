#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Employee.cs
// 
// Current Data:
// 2021-04-04 12:21 PM
// 
// Creation Date:
// -- 

#endregion

using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
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