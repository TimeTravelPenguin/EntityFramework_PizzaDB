#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: DeliveryEmployee.cs
// 
// Current Data:
// 2021-04-05 9:04 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

namespace PizzaDB.Entities
{
  public class DeliveryEmployee : Employee
  {
    public double? PayRatePerDelivery { get; set; }
  }
}