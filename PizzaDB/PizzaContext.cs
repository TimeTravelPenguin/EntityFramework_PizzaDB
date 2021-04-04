#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: PizzaContext.cs
// 
// Current Data:
// 2021-04-05 1:36 AM
// 
// Creation Date:
// 2021-04-04 4:32 PM

#endregion

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PizzaDB.Entities;

namespace PizzaDB
{
  public class PizzaContext : DbContext
  {
    private readonly string _connectionString;

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Bank> Banks { get; set; }
    public virtual DbSet<BankAccount> BankAccounts { get; set; }
    public virtual DbSet<Contact> Contacts { get; set; }
    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
    public virtual DbSet<DeliveryEmployee> DeliveryEmployees { get; set; }
    public virtual DbSet<Discount> Discounts { get; set; }
    public virtual DbSet<Employee> Employees { get; set; }
    public virtual DbSet<Ingredient> Ingredients { get; set; }
    public virtual DbSet<IngredientStock> IngredientStocks { get; set; }
    public virtual DbSet<MenuItem> MenuItems { get; set; }
    public virtual DbSet<MenuItemIngredient> MenuItemIngredients { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<StockTake> StockTakes { get; set; }
    public virtual DbSet<StoreEmployee> StoreEmployees { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }

    public PizzaContext()
    {
      var builder = new ConfigurationBuilder();
      builder.AddJsonFile("appsettings.json", false);
      var configuration = builder.Build();
      _connectionString = configuration.GetConnectionString("PizzaDB");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);

      optionsBuilder.UseSqlServer(_connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
  }
}