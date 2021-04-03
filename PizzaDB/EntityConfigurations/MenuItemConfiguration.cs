using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            builder.HasMany(menuItem => menuItem.Ingredients)
                .WithMany(ing => ing.MenuItems)
                .UsingEntity(m => m.ToTable("MenuItemIngredients"));
        }
    }
}