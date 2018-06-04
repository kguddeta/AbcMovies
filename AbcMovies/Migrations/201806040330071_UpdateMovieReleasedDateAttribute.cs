namespace AbcMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieReleasedDateAttribute : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Releasedate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Releasedate", c => c.DateTime(nullable: false));
        }
    }
}
