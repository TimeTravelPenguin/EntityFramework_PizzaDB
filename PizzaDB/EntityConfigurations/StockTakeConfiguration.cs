using System.Data.Entity.ModelConfiguration;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class StockTakeConfiguration : EntityTypeConfiguration<StockTake>
    {
        public StockTakeConfiguration()
        {
            HasKey(st => new {st.IngredientId, st.DateTime});

            HasRequired(st => st.Ingredient)
                .WithMany(ing => ing.StockTakes)
                .HasForeignKey(st => st.IngredientId);
        }
    }
}