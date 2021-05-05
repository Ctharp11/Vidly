namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 1, '2050618', '20120618', 7)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, '19870618', '20120618', 12)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 1991, '20120618', '20120618', 9)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 4, '199820618', '20120618', 3)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('La La Land', 11, '20170618', '20120618', 4)");
        }
        
        public override void Down()
        {
        }
    }
}
