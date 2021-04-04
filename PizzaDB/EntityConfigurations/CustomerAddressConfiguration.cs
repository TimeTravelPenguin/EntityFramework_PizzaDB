#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: CustomerAddressConfiguration.cs
// 
// Current Data:
// 2021-04-04 6:50 PM
// 
// Creation Date:
// 2021-04-04 4:32 PM

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
  public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
  {
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
      builder.HasKey(x => new {x.CustomerId, x.AddressId});
    }
  }
}