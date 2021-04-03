namespace PizzaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRequiredToDiscountDescription : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Discounts", "Description", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Discounts", "Description", c => c.String(maxLength: 200));
        }
    }
}
