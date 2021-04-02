using System.Data.Entity.ModelConfiguration;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class MenuItemConfiguration : EntityTypeConfiguration<MenuItem>
    {
        public MenuItemConfiguration()
        {
            HasMany(menuItem => menuItem.Ingredients)
                .WithMany(ing => ing.MenuItems)
                .Map(m =>
                {
                    m.ToTable("MenuItemIngredients");
                    m.MapLeftKey("menuItemId");
                    m.MapRightKey("ingredientId");
                });
        }
    }
}