namespace AbcMovies.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Customers(Name,BirthDate,IsSubscribedToNewsLetter,MembershipTypeId) VALUES('John Smith','01/10/1990','true',1)");
            Sql("INSERT INTO Customers(Name,BirthDate,IsSubscribedToNewsLetter,MembershipTypeId) VALUES('Mary Williams','11/02/1985','false',2)");
            Sql("INSERT INTO Customers(Name,BirthDate,IsSubscribedToNewsLetter,MembershipTypeId) VALUES('Jems David','04/21/1983','true',3)");
        }
        
        public override void Down()
        {
        }
    }
}
