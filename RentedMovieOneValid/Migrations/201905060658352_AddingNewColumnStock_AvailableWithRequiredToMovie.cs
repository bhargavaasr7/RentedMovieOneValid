namespace RentedMovieOneValid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewColumnStock_AvailableWithRequiredToMovie : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "MovieName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "MovieName", c => c.String());
        }
    }
}
