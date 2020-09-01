namespace HSM_Music.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "GenreId", c => c.Byte(nullable: false));
        }
    }
}
