namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameMenuItemIngredientFKs : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.MenuItemIngredients", name: "MenuItem", newName: "menuItemId");
            RenameColumn(table: "dbo.MenuItemIngredients", name: "Ingredient", newName: "ingredientId");
            RenameIndex(table: "dbo.MenuItemIngredients", name: "IX_MenuItem", newName: "IX_menuItemId");
            RenameIndex(table: "dbo.MenuItemIngredients", name: "IX_Ingredient", newName: "IX_ingredientId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.MenuItemIngredients", name: "IX_ingredientId", newName: "IX_Ingredient");
            RenameIndex(table: "dbo.MenuItemIngredients", name: "IX_menuItemId", newName: "IX_MenuItem");
            RenameColumn(table: "dbo.MenuItemIngredients", name: "ingredientId", newName: "Ingredient");
            RenameColumn(table: "dbo.MenuItemIngredients", name: "menuItemId", newName: "MenuItem");
        }
    }
}
