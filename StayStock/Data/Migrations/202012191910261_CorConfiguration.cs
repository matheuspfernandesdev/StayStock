namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorConfiguration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cor", "CodigoCor", c => c.String(maxLength: 10, unicode: false));
            DropColumn("dbo.Cor", "CodigoHex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cor", "CodigoHex", c => c.String(maxLength: 10, unicode: false));
            DropColumn("dbo.Cor", "CodigoCor");
        }
    }
}
