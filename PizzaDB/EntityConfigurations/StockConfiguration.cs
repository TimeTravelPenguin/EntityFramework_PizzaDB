using System.Data.Entity.ModelConfiguration;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class StockConfiguration : EntityTypeConfiguration<Stock>
    {
        public StockConfiguration()
        {
            ToTable("Stock");

            HasKey(st => st.IngredientId);

            HasRequired(st => st.Ingredient)
                .WithRequiredDependent(ing => ing.Stock);
        }
    }
}