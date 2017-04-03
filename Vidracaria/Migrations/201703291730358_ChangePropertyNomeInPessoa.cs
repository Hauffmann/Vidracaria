namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePropertyNomeInPessoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "Nome", c => c.String());
        }
    }
}
