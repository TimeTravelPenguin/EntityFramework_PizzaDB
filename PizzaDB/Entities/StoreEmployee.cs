#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: StoreEmployee.cs
// 
// Current Data:
// 2021-04-05 8:53 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("StoreEmployees")]
  public class StoreEmployee : Employee
  {
    public double? PayRatePerHour { get; set; }
  }
}