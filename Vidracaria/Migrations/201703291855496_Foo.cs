namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Enderecoes", "Logradouro", c => c.String(nullable: false));
            AlterColumn("dbo.Enderecoes", "Numero", c => c.Int(nullable: false));
            AlterColumn("dbo.Enderecoes", "Bairro", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Enderecoes", "Bairro", c => c.String());
            AlterColumn("dbo.Enderecoes", "Numero", c => c.Int());
            AlterColumn("dbo.Enderecoes", "Logradouro", c => c.String());
        }
    }
}
