namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateStockTake : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StockTakes", "IngredientId", "dbo.Ingredients");
            DropIndex("dbo.StockTakes", new[] { "IngredientId" });
            DropTable("dbo.StockTakes");
        }
    }
}
