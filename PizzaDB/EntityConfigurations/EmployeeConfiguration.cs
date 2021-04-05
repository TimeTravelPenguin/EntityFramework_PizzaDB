#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: EmployeeConfiguration.cs
// 
// Current Data:
// 2021-04-05 9:06 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;
using PizzaDB.Entities.Types;

namespace PizzaDB.EntityConfigurations
{
  public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
  {
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
      builder.HasDiscriminator<EmployeeType>("EmployeeType")
        .HasValue<Employee>(EmployeeType.Default)
        .HasValue<StoreEmployee>(EmployeeType.Store)
        .HasValue<DeliveryEmployee>(EmployeeType.Delivery);
    }
  }
}