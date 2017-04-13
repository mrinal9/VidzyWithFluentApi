namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UsingFluntApiToChangeVideoAndGenres : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Videos", new[] { "GenreId" });
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "GennreId");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "GennreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "GennreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Videos", new[] { "GennreId" });
            AlterColumn("dbo.Videos", "GennreId", c => c.Int());
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            RenameColumn(table: "dbo.Videos", name: "GennreId", newName: "GenreId");
            CreateIndex("dbo.Videos", "GenreId");
        }
    }
}
