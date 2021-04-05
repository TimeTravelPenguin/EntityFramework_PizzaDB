#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: IngredientSupplierConfiguration.cs
// 
// Current Data:
// 2021-04-05 9:27 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
  public class IngredientSupplierConfiguration : IEntityTypeConfiguration<IngredientSupplier>
  {
    public void Configure(EntityTypeBuilder<IngredientSupplier> builder)
    {
      builder.HasKey(x => new {x.IngredientId, x.SupplierId});
    }
  }
}