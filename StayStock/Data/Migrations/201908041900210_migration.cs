namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        ClienteEspecial = c.Boolean(nullable: false),
                        Inadimplente = c.Boolean(nullable: false),
                        EnderecoIdentificador = c.Int(),
                        CodigoCpfCnpj = c.String(maxLength: 30, unicode: false),
                        Identidade = c.String(maxLength: 30, unicode: false),
                        Telefone = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        DataNascimento = c.DateTime(),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Endereco", t => t.EnderecoIdentificador)
                .Index(t => t.EnderecoIdentificador);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Bairro = c.String(nullable: false, maxLength: 50, unicode: false),
                        Rua = c.String(nullable: false, maxLength: 50, unicode: false),
                        Numero = c.String(nullable: false, maxLength: 10, unicode: false),
                        CEP = c.Int(),
                        Municipio = c.String(nullable: false, maxLength: 50, unicode: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador);
            
            CreateTable(
                "dbo.EmpresaLocal",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NomeFantasia = c.String(maxLength: 100, unicode: false),
                        CNPJ = c.String(nullable: false, maxLength: 30, unicode: false),
                        EnderecoIdentificador = c.Int(nullable: false),
                        IdentificadorFuncionarioGestor = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Endereco", t => t.EnderecoIdentificador)
                .ForeignKey("dbo.Funcionario", t => t.IdentificadorFuncionarioGestor)
                .Index(t => t.EnderecoIdentificador)
                .Index(t => t.IdentificadorFuncionarioGestor);
            
            CreateTable(
                "dbo.Funcionario",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        EnderecoIdentificador = c.Int(),
                        CargaHoraria = c.String(nullable: false, maxLength: 100, unicode: false),
                        Salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumeroPIS = c.Long(),
                        NumeroCarteiraTrabalho = c.Long(),
                        IndicadorTipoFuncionario = c.Int(nullable: false),
                        CodigoCpfCnpj = c.String(maxLength: 30, unicode: false),
                        Identidade = c.String(maxLength: 30, unicode: false),
                        Telefone = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        DataNascimento = c.DateTime(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Endereco", t => t.EnderecoIdentificador)
                .Index(t => t.EnderecoIdentificador);
            
            CreateTable(
                "dbo.Vale",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descricao = c.String(maxLength: 2000, unicode: false),
                        IdentificadorFuncionarioVale = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Funcionario", t => t.IdentificadorFuncionarioVale)
                .Index(t => t.IdentificadorFuncionarioVale);
            
            CreateTable(
                "dbo.Venda",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        IdentificadorCliente = c.Int(nullable: false),
                        IdentificadorFuncionario = c.Int(nullable: false),
                        EnderecoIdentificador = c.Int(),
                        Observacoes = c.String(maxLength: 1000, unicode: false),
                        ValorTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoPagamento = c.Int(nullable: false),
                        DataHoraEntrega = c.DateTime(),
                        QuantidadePromissoria = c.Int(),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Cliente", t => t.IdentificadorCliente)
                .ForeignKey("dbo.Endereco", t => t.EnderecoIdentificador)
                .ForeignKey("dbo.Funcionario", t => t.IdentificadorFuncionario)
                .Index(t => t.IdentificadorCliente)
                .Index(t => t.IdentificadorFuncionario)
                .Index(t => t.EnderecoIdentificador);
            
            CreateTable(
                "dbo.Promissoria",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        DataVencimento = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorPorExtenso = c.String(maxLength: 100, unicode: false),
                        IdentificadorVenda = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Venda", t => t.IdentificadorVenda)
                .Index(t => t.IdentificadorVenda);
            
            CreateTable(
                "dbo.VendaProdutoCor",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        IdentificadorVenda = c.Int(nullable: false),
                        IdentificadorProdutoCor = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.ProdutoCor", t => t.IdentificadorProdutoCor)
                .ForeignKey("dbo.Venda", t => t.IdentificadorVenda)
                .Index(t => t.IdentificadorVenda)
                .Index(t => t.IdentificadorProdutoCor);
            
            CreateTable(
                "dbo.ProdutoCor",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        IdentificadorCor = c.Int(),
                        IdentificadorProduto = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Cor", t => t.IdentificadorCor)
                .ForeignKey("dbo.Produto", t => t.IdentificadorProduto)
                .Index(t => t.IdentificadorCor)
                .Index(t => t.IdentificadorProduto);
            
            CreateTable(
                "dbo.Cor",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        NomeCor = c.String(nullable: false, maxLength: 50, unicode: false),
                        CodigoHex = c.String(maxLength: 10, unicode: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador);
            
            CreateTable(
                "dbo.ProdutoEmEstoque",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        IdentificadorProdutoCor = c.Int(nullable: false),
                        Quantidade = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.ProdutoCor", t => t.IdentificadorProdutoCor)
                .Index(t => t.IdentificadorProdutoCor);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        NumeroSerie = c.String(maxLength: 50, unicode: false),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdentificadorTipoProduto = c.Int(nullable: false),
                        IdentificadorFabrica = c.Int(nullable: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Fabrica", t => t.IdentificadorFabrica)
                .ForeignKey("dbo.TipoProduto", t => t.IdentificadorTipoProduto)
                .Index(t => t.IdentificadorTipoProduto)
                .Index(t => t.IdentificadorFabrica);
            
            CreateTable(
                "dbo.Fabrica",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        EnderecoIdentificador = c.Int(),
                        CNPJ = c.String(maxLength: 30, unicode: false),
                        Email = c.String(maxLength: 50, unicode: false),
                        Descricao = c.String(maxLength: 2000, unicode: false),
                        Telefone = c.String(maxLength: 25, unicode: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador)
                .ForeignKey("dbo.Endereco", t => t.EnderecoIdentificador)
                .Index(t => t.EnderecoIdentificador);
            
            CreateTable(
                "dbo.TipoProduto",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 1000, unicode: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador);
            
            CreateTable(
                "dbo.Financeira",
                c => new
                    {
                        Identificador = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100, unicode: false),
                        Usuario = c.String(nullable: false, maxLength: 30, unicode: false),
                        Login = c.String(nullable: false, maxLength: 30, unicode: false),
                        Senha = c.String(nullable: false, maxLength: 100, unicode: false),
                        Descricao = c.String(maxLength: 2000, unicode: false),
                        DataHoraInclusao = c.DateTime(nullable: false),
                        DataHoraUltimaAlteracao = c.DateTime(nullable: false),
                        DataHoraExclusao = c.DateTime(),
                    })
                .PrimaryKey(t => t.Identificador);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "EnderecoIdentificador", "dbo.Endereco");
            DropForeignKey("dbo.EmpresaLocal", "IdentificadorFuncionarioGestor", "dbo.Funcionario");
            DropForeignKey("dbo.VendaProdutoCor", "IdentificadorVenda", "dbo.Venda");
            DropForeignKey("dbo.VendaProdutoCor", "IdentificadorProdutoCor", "dbo.ProdutoCor");
            DropForeignKey("dbo.ProdutoCor", "IdentificadorProduto", "dbo.Produto");
            DropForeignKey("dbo.Produto", "IdentificadorTipoProduto", "dbo.TipoProduto");
            DropForeignKey("dbo.Produto", "IdentificadorFabrica", "dbo.Fabrica");
            DropForeignKey("dbo.Fabrica", "EnderecoIdentificador", "dbo.Endereco");
            DropForeignKey("dbo.ProdutoEmEstoque", "IdentificadorProdutoCor", "dbo.ProdutoCor");
            DropForeignKey("dbo.ProdutoCor", "IdentificadorCor", "dbo.Cor");
            DropForeignKey("dbo.Promissoria", "IdentificadorVenda", "dbo.Venda");
            DropForeignKey("dbo.Venda", "IdentificadorFuncionario", "dbo.Funcionario");
            DropForeignKey("dbo.Venda", "EnderecoIdentificador", "dbo.Endereco");
            DropForeignKey("dbo.Venda", "IdentificadorCliente", "dbo.Cliente");
            DropForeignKey("dbo.Vale", "IdentificadorFuncionarioVale", "dbo.Funcionario");
            DropForeignKey("dbo.Funcionario", "EnderecoIdentificador", "dbo.Endereco");
            DropForeignKey("dbo.EmpresaLocal", "EnderecoIdentificador", "dbo.Endereco");
            DropIndex("dbo.Fabrica", new[] { "EnderecoIdentificador" });
            DropIndex("dbo.Produto", new[] { "IdentificadorFabrica" });
            DropIndex("dbo.Produto", new[] { "IdentificadorTipoProduto" });
            DropIndex("dbo.ProdutoEmEstoque", new[] { "IdentificadorProdutoCor" });
            DropIndex("dbo.ProdutoCor", new[] { "IdentificadorProduto" });
            DropIndex("dbo.ProdutoCor", new[] { "IdentificadorCor" });
            DropIndex("dbo.VendaProdutoCor", new[] { "IdentificadorProdutoCor" });
            DropIndex("dbo.VendaProdutoCor", new[] { "IdentificadorVenda" });
            DropIndex("dbo.Promissoria", new[] { "IdentificadorVenda" });
            DropIndex("dbo.Venda", new[] { "EnderecoIdentificador" });
            DropIndex("dbo.Venda", new[] { "IdentificadorFuncionario" });
            DropIndex("dbo.Venda", new[] { "IdentificadorCliente" });
            DropIndex("dbo.Vale", new[] { "IdentificadorFuncionarioVale" });
            DropIndex("dbo.Funcionario", new[] { "EnderecoIdentificador" });
            DropIndex("dbo.EmpresaLocal", new[] { "IdentificadorFuncionarioGestor" });
            DropIndex("dbo.EmpresaLocal", new[] { "EnderecoIdentificador" });
            DropIndex("dbo.Cliente", new[] { "EnderecoIdentificador" });
            DropTable("dbo.Financeira");
            DropTable("dbo.TipoProduto");
            DropTable("dbo.Fabrica");
            DropTable("dbo.Produto");
            DropTable("dbo.ProdutoEmEstoque");
            DropTable("dbo.Cor");
            DropTable("dbo.ProdutoCor");
            DropTable("dbo.VendaProdutoCor");
            DropTable("dbo.Promissoria");
            DropTable("dbo.Venda");
            DropTable("dbo.Vale");
            DropTable("dbo.Funcionario");
            DropTable("dbo.EmpresaLocal");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
        }
    }
}
