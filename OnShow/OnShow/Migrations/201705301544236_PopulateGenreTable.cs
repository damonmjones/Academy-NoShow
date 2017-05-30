namespace OnShow.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id ,Name) VALUES ('5683A595-B432-4AE1-82F3-216B64A0F8F3', 'Pop')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES ('43F3191D-573F-45E0-A6E1-1AAC2E61E46C', 'Rock')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES ('081CFE10-1688-44E9-97CD-D664E1289BAD', 'Jazz')");
            Sql("INSERT INTO Genres (Id ,Name) VALUES ('D0529246-1C8A-42A0-A5BE-45128585C777', 'Blues')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN ('5683A595-B432-4AE1-82F3-216B64A0F8F3', '43F3191D-573F-45E0-A6E1-1AAC2E61E46C', " +
                "'081CFE10-1688-44E9-97CD-D664E1289BAD', 'D0529246-1C8A-42A0-A5BE-45128585C777')");
        }
    }
}
