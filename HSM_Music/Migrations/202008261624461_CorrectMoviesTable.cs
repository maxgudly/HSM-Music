namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrectMoviesTable : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Movies", name: "GenreName_Id", newName: "Genre_Id");
            RenameIndex(table: "dbo.Movies", name: "IX_GenreName_Id", newName: "IX_Genre_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Movies", name: "IX_Genre_Id", newName: "IX_GenreName_Id");
            RenameColumn(table: "dbo.Movies", name: "Genre_Id", newName: "GenreName_Id");
        }
    }
}
