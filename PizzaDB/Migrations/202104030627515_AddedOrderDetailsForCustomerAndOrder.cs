namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOrderDetailsForCustomerAndOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            AddColumn("dbo.Payments", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Payments", "DiscountPercentage", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "PaymentSubTotal", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "PaymentTax", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "PaymentTotal", c => c.Double(nullable: false));
            AddColumn("dbo.Payments", "DateTimeOrderPlaced", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "DateTimeOrderDue", c => c.DateTime(nullable: false));
            AddColumn("dbo.Payments", "DateTimeOrderFulfilled", c => c.DateTime());
            CreateIndex("dbo.Payments", "CustomerId");
            AddForeignKey("dbo.Payments", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropColumn("dbo.Payments", "DateTimeOrderFulfilled");
            DropColumn("dbo.Payments", "DateTimeOrderDue");
            DropColumn("dbo.Payments", "DateTimeOrderPlaced");
            DropColumn("dbo.Payments", "PaymentTotal");
            DropColumn("dbo.Payments", "PaymentTax");
            DropColumn("dbo.Payments", "PaymentSubTotal");
            DropColumn("dbo.Payments", "DiscountPercentage");
            DropColumn("dbo.Payments", "CustomerId");
            DropTable("dbo.Customers");
        }
    }
}
