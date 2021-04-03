using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class IngredientsConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasMany(ing => ing.MenuItems)
                .WithMany(menuItem => menuItem.Ingredients)
                .UsingEntity<Dictionary<string, object>>("MenuItemIngredients",
                    entity => entity.HasOne<MenuItem>()
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .HasConstraintName("FK_MenuItemIngredients_MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade),
                    entity => entity
                        .HasOne<Ingredient>()
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .HasConstraintName("FK_MenuItemIngredients_IngredientId")
                        .OnDelete(DeleteBehavior.ClientCascade));

            builder.HasMany(ing => ing.IngredientSuppliers)
                .WithMany(supplier => supplier.SuppliedIngredients)
                .UsingEntity<Dictionary<string, object>>("IngredientSuppliers",
                    entity => entity.HasOne<Supplier>()
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .HasConstraintName("FK_IngredientSuppliers_SupplierId")
                        .OnDelete(DeleteBehavior.Cascade),
                    entity => entity
                        .HasOne<Ingredient>()
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .HasConstraintName("FK_IngredientSuppliers_IngredientId")
                        .OnDelete(DeleteBehavior.Cascade));
        }
    }
}