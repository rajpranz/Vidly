namespace Vidly.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class makeGenretypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES (1, 'SciFi')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (3, 'Romance')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (4, 'Action')");
            Sql("INSERT INTO Genres(Id, Name) VALUES (5, 'Animated')");
        }

        public override void Down()
        {
        }
    }
}
