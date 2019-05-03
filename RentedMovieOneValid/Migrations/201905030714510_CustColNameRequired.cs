namespace RentedMovieOneValid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustColNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "name", c => c.String());
        }
    }
}
