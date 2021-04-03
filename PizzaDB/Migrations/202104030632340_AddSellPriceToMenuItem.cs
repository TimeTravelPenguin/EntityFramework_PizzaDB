namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSellPriceToMenuItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MenuItems", "SellPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MenuItems", "SellPrice");
        }
    }
}
