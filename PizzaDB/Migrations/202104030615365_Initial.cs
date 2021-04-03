namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        DiscountId = c.Int(nullable: false, identity: true),
                        DiscountCode = c.Int(nullable: false),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.DiscountId)
                .Index(t => t.DiscountCode, unique: true);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        IngredientId = c.Int(nullable: false, identity: true),
                        IngredientName = c.String(maxLength: 25),
                        IngredientStockId = c.Int(nullable: false),
                        IngredientType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientId)
                .ForeignKey("dbo.IngredientStocks", t => t.IngredientStockId, cascadeDelete: true)
                .Index(t => t.IngredientStockId);
            
            CreateTable(
                "dbo.IngredientStocks",
                c => new
                    {
                        IngredientStockId = c.Int(nullable: false, identity: true),
                        CurrentStockLevel = c.Int(nullable: false),
                        RecommendedStockLevel = c.Int(nullable: false),
                        ReorderStockLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientStockId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StockTakes",
                c => new
                    {
                        IngredientId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        StockLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IngredientId, t.DateTime })
                .ForeignKey("dbo.Ingredients", t => t.IngredientId, cascadeDelete: true)
                .Index(t => t.IngredientId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        PaymentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Payments", t => t.PaymentId, cascadeDelete: true)
                .Index(t => t.PaymentId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        PaymentId = c.Int(nullable: false, identity: true),
                        DiscountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PaymentId)
                .ForeignKey("dbo.Discounts", t => t.DiscountId, cascadeDelete: true)
                .Index(t => t.DiscountId);
            
            CreateTable(
                "dbo.IngredientSuppliers",
                c => new
                    {
                        IngredientId = c.Int(nullable: false),
                        SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IngredientId, t.SupplierId })
                .ForeignKey("dbo.Ingredients", t => t.IngredientId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.IngredientId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.MenuItemIngredients",
                c => new
                    {
                        menuItemId = c.Int(nullable: false),
                        ingredientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.menuItemId, t.ingredientId })
                .ForeignKey("dbo.MenuItems", t => t.menuItemId, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.ingredientId, cascadeDelete: true)
                .Index(t => t.menuItemId)
                .Index(t => t.ingredientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PaymentId", "dbo.Payments");
            DropForeignKey("dbo.Payments", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.StockTakes", "IngredientId", "dbo.Ingredients");
            DropForeignKey("dbo.MenuItemIngredients", "ingredientId", "dbo.Ingredients");
            DropForeignKey("dbo.MenuItemIngredients", "menuItemId", "dbo.MenuItems");
            DropForeignKey("dbo.IngredientSuppliers", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.IngredientSuppliers", "IngredientId", "dbo.Ingredients");
            DropForeignKey("dbo.Ingredients", "IngredientStockId", "dbo.IngredientStocks");
            DropIndex("dbo.MenuItemIngredients", new[] { "ingredientId" });
            DropIndex("dbo.MenuItemIngredients", new[] { "menuItemId" });
            DropIndex("dbo.IngredientSuppliers", new[] { "SupplierId" });
            DropIndex("dbo.IngredientSuppliers", new[] { "IngredientId" });
            DropIndex("dbo.Payments", new[] { "DiscountId" });
            DropIndex("dbo.Orders", new[] { "PaymentId" });
            DropIndex("dbo.StockTakes", new[] { "IngredientId" });
            DropIndex("dbo.Ingredients", new[] { "IngredientStockId" });
            DropIndex("dbo.Discounts", new[] { "DiscountCode" });
            DropTable("dbo.MenuItemIngredients");
            DropTable("dbo.IngredientSuppliers");
            DropTable("dbo.Payments");
            DropTable("dbo.Orders");
            DropTable("dbo.StockTakes");
            DropTable("dbo.MenuItems");
            DropTable("dbo.Suppliers");
            DropTable("dbo.IngredientStocks");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Discounts");
        }
    }
}
