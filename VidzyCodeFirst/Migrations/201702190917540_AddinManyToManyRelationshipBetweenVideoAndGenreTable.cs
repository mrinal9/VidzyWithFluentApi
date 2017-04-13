namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddinManyToManyRelationshipBetweenVideoAndGenreTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoGenres",
                c => new
                    {
                        VideoId = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new {t.VideoId, t.GenreId })
                .ForeignKey("dbo.Videos", t => t.VideoId, cascadeDelete: true)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.VideoId)
                .Index(t => t.GenreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VideoGenres", "GenreId", "dbo.Genres");
            DropForeignKey("dbo.VideoGenres", "VideoId", "dbo.Videos");
            DropIndex("dbo.VideoGenres", new[] { "GenreId" });
            DropIndex("dbo.VideoGenres", new[] { "VideoId" });
            DropTable("dbo.VideoGenres");
        }
    }
}
