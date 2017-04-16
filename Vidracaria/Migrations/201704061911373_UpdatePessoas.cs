namespace Vidracaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePessoas : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoas", "Cpf", c => c.String());
            AlterColumn("dbo.Pessoas", "Rg", c => c.String());
            AlterColumn("dbo.Pessoas", "Cnpj", c => c.String());
            AlterColumn("dbo.Pessoas", "InscricaoEstadual", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoas", "InscricaoEstadual", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Pessoas", "Cnpj", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Pessoas", "Rg", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Pessoas", "Cpf", c => c.Decimal(precision: 18, scale: 2));
        }
    }
}
