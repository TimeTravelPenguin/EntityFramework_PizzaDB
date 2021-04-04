using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
  public class MenuItemIngredientConfiguration : IEntityTypeConfiguration<MenuItemIngredient>
  {
    public void Configure(EntityTypeBuilder<MenuItemIngredient> builder)
    {
      builder.HasKey(x => new {x.MenuItemId, x.IngredientId});
    }
  }
}