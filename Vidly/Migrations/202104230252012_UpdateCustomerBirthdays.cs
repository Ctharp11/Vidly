namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerBirthdays : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '20120618' WHERE Name = 'John Smith'");
            Sql("UPDATE Customers SET Birthday = '19901021' WHERE Name = 'Poop McGee'");
        }
        
        public override void Down()
        {
        }
    }
}
