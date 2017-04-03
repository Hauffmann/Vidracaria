namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludeDateofBirthOnPessoa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "DataNascimento", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "DataNascimento");
        }
    }
}
