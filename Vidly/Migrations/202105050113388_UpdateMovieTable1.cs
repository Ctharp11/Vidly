namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovieTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 1, 2011-11-03, 2017-11-03, 7)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, 1982-11-03, 2017-11-03, 12)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 2, 1987-11-03, 2017-11-03, 9)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 4, 1998-11-03, 2017-11-03, 3)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('La La Land', 11, 2017-11-03, 2017-11-03, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
