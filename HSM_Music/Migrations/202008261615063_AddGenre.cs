namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenreName = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
            AddColumn("dbo.Movies", "GenreName_Id", c => c.Int());
            CreateIndex("dbo.Movies", "GenreName_Id");
            AddForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "GenreName_Id", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreName_Id" });
            DropColumn("dbo.Movies", "GenreName_Id");
            DropColumn("dbo.Movies", "GenreId");
            DropTable("dbo.Genres");
        }
    }
}
