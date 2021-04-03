using System.Data.Entity;
using System.Reflection;
using PizzaDB.Entities;

namespace PizzaDB
{
    public class PizzaContext : DbContext
    {
        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<IngredientStock> Stocks { get; set; }
        public virtual DbSet<StockTake> StockTakes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }

        public PizzaContext()
            : base("name=PizzaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations
                .AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}