namespace AbcMovies.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMovie : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MOvies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES('Hangover','10/02/2011','12/04/2016',10,1)");
            Sql("INSERT INTO MOvies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES('Die Hard','01/02/2013','10/02/2016',15,2)");
            Sql("INSERT INTO MOvies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES('The Terminator','08/17/2008','02/01/2016',30,2)");
            Sql("INSERT INTO MOvies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES('Toy Story','12/01/2014','11/03/2016',31,3)");
            Sql("INSERT INTO MOvies(Name,ReleaseDate,DateAdded,NumberInStock,GenreId) VALUES('Titanic','05/02/2000','05/01/2016',13,4)");
        }
        
        public override void Down()
        {
        }
    }
}
