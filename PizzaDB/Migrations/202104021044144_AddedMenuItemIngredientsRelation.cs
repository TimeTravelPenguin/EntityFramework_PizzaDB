namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMenuItemIngredientsRelation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MenuItemIngredients",
                c => new
                    {
                        MenuItem = c.Int(nullable: false),
                        Ingredient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenuItem, t.Ingredient })
                .ForeignKey("dbo.MenuItems", t => t.MenuItem, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.Ingredient, cascadeDelete: true)
                .Index(t => t.MenuItem)
                .Index(t => t.Ingredient);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MenuItemIngredients", "Ingredient", "dbo.Ingredients");
            DropForeignKey("dbo.MenuItemIngredients", "MenuItem", "dbo.MenuItems");
            DropIndex("dbo.MenuItemIngredients", new[] { "Ingredient" });
            DropIndex("dbo.MenuItemIngredients", new[] { "MenuItem" });
            DropTable("dbo.MenuItemIngredients");
        }
    }
}
