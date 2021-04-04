#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: SupplierIngredientConfiguration.cs
// 
// Current Data:
// 2021-04-05 8:23 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
  public class SupplierIngredientConfiguration : IEntityTypeConfiguration<MenuItemIngredient>
  {
    public void Configure(EntityTypeBuilder<MenuItemIngredient> builder)
    {
      builder.HasKey(x => new {x.MenuItemId, x.IngredientId});
    }
  }
}