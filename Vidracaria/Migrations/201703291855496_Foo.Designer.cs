// <auto-generated />
namespace Vidracaria.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class Foo : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(Foo));
        
        string IMigrationMetadata.Id
        {
            get { return "201703291855496_Foo"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}