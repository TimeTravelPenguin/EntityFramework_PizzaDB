#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: CustomerAddress.cs
// 
// Current Data:
// 2021-04-05 9:30 AM
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
    [ForeignKey(nameof(Customer))] public int CustomerId { get; set; }

    public Customer Customer { get; set; }

    [ForeignKey(nameof(Address))] public int AddressId { get; set; }

    public Address Address { get; set; }
  }
}