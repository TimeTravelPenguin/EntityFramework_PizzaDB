using System.Data.Entity.ModelConfiguration;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class IngredientConfiguration : EntityTypeConfiguration<Ingredient>
    {
        public IngredientConfiguration()
        {
            HasMany(ing => ing.IngredientSuppliers)
                .WithMany(sup => sup.SuppliedIngredients)
                .Map(m =>
                {
                    m.ToTable("IngredientSuppliers");
                    m.MapLeftKey("IngredientId");
                    m.MapRightKey("SupplierId");
                });
        }
    }
}