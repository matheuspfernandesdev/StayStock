namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cor", "CodigoCor", c => c.String(maxLength: 20, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cor", "CodigoCor", c => c.String(maxLength: 10, unicode: false));
        }
    }
}
