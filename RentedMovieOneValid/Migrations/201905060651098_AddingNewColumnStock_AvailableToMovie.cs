namespace RentedMovieOneValid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewColumnStock_AvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Stock_Available", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Stock_Available");
        }
    }
}
