﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaDB;

namespace PizzaDB.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20210404223445_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressCustomer", b =>
                {
                    b.Property<int>("AddressesAddressId")
                        .HasColumnType("int");

                    b.Property<int>("CustomersCustomerId")
                        .HasColumnType("int");

                    b.HasKey("AddressesAddressId", "CustomersCustomerId");

                    b.HasIndex("CustomersCustomerId");

                    b.ToTable("AddressCustomer");
                });

            modelBuilder.Entity("IngredientMenuItem", b =>
                {
                    b.Property<int>("IngredientsIngredientId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemsMenuItemId")
                        .HasColumnType("int");

                    b.HasKey("IngredientsIngredientId", "MenuItemsMenuItemId");

                    b.HasIndex("MenuItemsMenuItemId");

                    b.ToTable("IngredientMenuItem");
                });

            modelBuilder.Entity("IngredientSupplier", b =>
                {
                    b.Property<int>("IngredientSuppliersSupplierId")
                        .HasColumnType("int");

                    b.Property<int>("SuppliedIngredientsIngredientId")
                        .HasColumnType("int");

                    b.HasKey("IngredientSuppliersSupplierId", "SuppliedIngredientsIngredientId");

                    b.HasIndex("SuppliedIngredientsIngredientId");

                    b.ToTable("IngredientSupplier");
                });

            modelBuilder.Entity("PizzaDB.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Suburb")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("PizzaDB.Entities.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Bsb")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("BankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("PizzaDB.Entities.BankAccount", b =>
                {
                    b.Property<int>("BankAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.HasKey("BankAccountId");

                    b.HasIndex("BankId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("PizzaDB.Entities.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("AUS contact number in form: 0123 456 789");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("PizzaDB.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("PizzaDB.Entities.CustomerAddress", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("CustomerAddresses");
                });

            modelBuilder.Entity("PizzaDB.Entities.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("DiscountCode")
                        .HasColumnType("int");

                    b.HasKey("DiscountId");

                    b.HasIndex("DiscountCode")
                        .IsUnique();

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("PizzaDB.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("BankAccountId")
                        .HasColumnType("int");

                    b.Property<int>("ContactId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxFileNumber")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("AddressId");

                    b.HasIndex("BankAccountId");

                    b.HasIndex("ContactId");

                    b.ToTable("Employees");

                    b.HasDiscriminator<int>("EmployeeType");
                });

            modelBuilder.Entity("PizzaDB.Entities.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IngredientName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("IngredientType")
                        .HasColumnType("int");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("PizzaDB.Entities.IngredientStock", b =>
                {
                    b.Property<int>("IngredientStockId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentStockLevel")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("RecommendedStockLevel")
                        .HasColumnType("int");

                    b.Property<int>("ReorderStockLevel")
                        .HasColumnType("int");

                    b.HasKey("IngredientStockId");

                    b.HasIndex("IngredientId");

                    b.ToTable("IngredientStocks");
                });

            modelBuilder.Entity("PizzaDB.Entities.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("SellPrice")
                        .HasColumnType("float");

                    b.HasKey("MenuItemId");

                    b.ToTable("MenuItems");
                });

            modelBuilder.Entity("PizzaDB.Entities.MenuItemIngredient", b =>
                {
                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("MenuItemIngredients");
                });

            modelBuilder.Entity("PizzaDB.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeOrderDue")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeOrderFulfilled")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeOrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaDB.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("float");

                    b.Property<double>("PaymentSubTotal")
                        .HasColumnType("float");

                    b.Property<double>("PaymentTax")
                        .HasColumnType("float");

                    b.Property<double>("PaymentTotal")
                        .HasColumnType("float");

                    b.HasKey("PaymentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DiscountId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("PizzaDB.Entities.StockTake", b =>
                {
                    b.Property<int>("StockTakeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("IngredientId")
                        .HasColumnType("int");

                    b.Property<int>("StockLevel")
                        .HasColumnType("int");

                    b.HasKey("StockTakeId");

                    b.HasIndex("IngredientId")
                        .IsUnique();

                    b.ToTable("StockTakes");
                });

            modelBuilder.Entity("PizzaDB.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("PizzaDB.Entities.DeliveryEmployee", b =>
                {
                    b.HasBaseType("PizzaDB.Entities.Employee");

                    b.Property<double?>("PayRatePerDelivery")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("PizzaDB.Entities.StoreEmployee", b =>
                {
                    b.HasBaseType("PizzaDB.Entities.Employee");

                    b.Property<double?>("PayRatePerHour")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue(0);
                });

            modelBuilder.Entity("AddressCustomer", b =>
                {
                    b.HasOne("PizzaDB.Entities.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientMenuItem", b =>
                {
                    b.HasOne("PizzaDB.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsIngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.MenuItem", null)
                        .WithMany()
                        .HasForeignKey("MenuItemsMenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IngredientSupplier", b =>
                {
                    b.HasOne("PizzaDB.Entities.Supplier", null)
                        .WithMany()
                        .HasForeignKey("IngredientSuppliersSupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("SuppliedIngredientsIngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaDB.Entities.BankAccount", b =>
                {
                    b.HasOne("PizzaDB.Entities.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bank");
                });

            modelBuilder.Entity("PizzaDB.Entities.CustomerAddress", b =>
                {
                    b.HasOne("PizzaDB.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PizzaDB.Entities.Employee", b =>
                {
                    b.HasOne("PizzaDB.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.BankAccount", "BankAccount")
                        .WithMany()
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("BankAccount");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("PizzaDB.Entities.IngredientStock", b =>
                {
                    b.HasOne("PizzaDB.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("PizzaDB.Entities.MenuItemIngredient", b =>
                {
                    b.HasOne("PizzaDB.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("PizzaDB.Entities.Order", b =>
                {
                    b.HasOne("PizzaDB.Entities.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("PizzaDB.Entities.Payment", b =>
                {
                    b.HasOne("PizzaDB.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaDB.Entities.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("PizzaDB.Entities.StockTake", b =>
                {
                    b.HasOne("PizzaDB.Entities.Ingredient", "Ingredient")
                        .WithMany("StockTakes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("PizzaDB.Entities.Ingredient", b =>
                {
                    b.Navigation("StockTakes");
                });
#pragma warning restore 612, 618
        }
    }
}