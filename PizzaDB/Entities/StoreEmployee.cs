#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: StoreEmployee.cs
// 
// Current Data:
// 2021-04-05 9:05 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

namespace PizzaDB.Entities
{
  public class StoreEmployee : Employee
  {
    public double? PayRatePerHour { get; set; }
  }
}