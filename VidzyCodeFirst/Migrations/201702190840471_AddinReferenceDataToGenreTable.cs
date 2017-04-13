namespace VidzyCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddinReferenceDataToGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres values('Action')");
            Sql("insert into genres values('Comedy')");
            Sql("insert into genres values('SciFi')");
            Sql("insert into genres values('Fantasy')");
        }
        
        public override void Down()
        {
            Sql("delete from genres");
        }
    }
}
