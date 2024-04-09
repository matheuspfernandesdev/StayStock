namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DescricaoProdutoCor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ProdutoCor", "Descricao", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ProdutoCor", "Descricao");
        }
    }
}
