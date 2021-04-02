namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateIngredientStock : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        IngredientId = c.Int(nullable: false),
                        CurrentStockLevel = c.Int(nullable: false),
                        RecommendedStockLevel = c.Int(nullable: false),
                        ReorderStockLevel = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IngredientId)
                .ForeignKey("dbo.Ingredients", t => t.IngredientId)
                .Index(t => t.IngredientId);
            
            DropColumn("dbo.Ingredients", "CurrentStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ingredients", "CurrentStock", c => c.Int(nullable: false));
            DropForeignKey("dbo.Stock", "IngredientId", "dbo.Ingredients");
            DropIndex("dbo.Stock", new[] { "IngredientId" });
            DropTable("dbo.Stock");
        }
    }
}
