using System.Data.Entity.ModelConfiguration;
using PizzaDB.Entities;

namespace PizzaDB.EntityConfigurations
{
    public class StockConfiguration : EntityTypeConfiguration<IngredientStock>
    {
        public StockConfiguration()
        {
        }
    }
}