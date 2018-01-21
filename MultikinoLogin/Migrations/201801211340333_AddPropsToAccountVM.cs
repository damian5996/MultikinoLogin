namespace MultikinoLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPropsToAccountVM : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Imie", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Nazwisko", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "Stanowisko", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Stanowisko");
            DropColumn("dbo.AspNetUsers", "Nazwisko");
            DropColumn("dbo.AspNetUsers", "Imie");
        }
    }
}
