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
        .HasValue<StoreEmployee>(EmployeeType.Store)
        .HasValue<DeliveryEmployee>(EmployeeType.Delivery);
    }
  }
}