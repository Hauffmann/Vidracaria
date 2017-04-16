namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldDescontoFormaPagamentos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FormaPagamentoes", "Desconto", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FormaPagamentoes", "Acrescimo", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FormaPagamentoes", "Acrescimo");
            DropColumn("dbo.FormaPagamentoes", "Desconto");
        }
    }
}
