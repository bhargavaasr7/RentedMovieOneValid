namespace RentedMovieOneValid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewColumnReleasedAndAddedToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "Adddate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Adddate");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
