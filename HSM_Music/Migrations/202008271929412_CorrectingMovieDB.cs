namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectingMovieDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Genres", "GenreName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "GenreName", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Genres", "Name");
        }
    }
}
