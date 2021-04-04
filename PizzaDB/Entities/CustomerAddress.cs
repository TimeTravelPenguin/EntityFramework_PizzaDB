#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: CustomerAddress.cs
// 
// Current Data:
// 2021-04-05 8:50 AM
// 
// Creation Date:
// 2021-04-04 9:47 PM

#endregion

using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("CustomerAddresses")]
  public class CustomerAddress
  {
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }
  }
}