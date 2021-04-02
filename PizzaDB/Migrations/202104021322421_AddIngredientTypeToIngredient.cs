namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIngredientTypeToIngredient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ingredients", "IngredientType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ingredients", "IngredientType");
        }
    }
}
