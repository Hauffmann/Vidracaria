namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColortoProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtoes", "Cor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtoes", "Cor");
        }
    }
}
