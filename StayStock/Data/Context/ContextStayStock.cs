using Data.EntityConfig;
using Data.EntityConfig.Administrativo;
using Data.EntityConfig.Estoque;
using Data.EntityConfig.Venda;
using Dominio.Entities.Administrativo;
using Dominio.Entities.Estoque;
using Dominio.Entities.Vendas;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Context
{
    public class ContextStayStock : DbContext
    {
        public ContextStayStock()
            : base("name=ConexaoPrincipal")
        {
            //EXEMPLO DE COMO USAR O INCLUDE PRA CARREGAR COM EAGER LOADING
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        #region [DbSet's]

        public DbSet<Cliente> ClienteDbSet { get; set; }
        public DbSet<EmpresaLocal> EmpresaLocalDbSet { get; set; }
        public DbSet<Endereco> EnderecoDbSet { get; set; }
        public DbSet<Fabrica> FabricaDbSet { get; set; }
        public DbSet<Financeira> FinanceiraDbSet { get; set; }
        public DbSet<Funcionario> FuncionarioDbSet { get; set; }
        public DbSet<Vale> ValeDbSet { get; set; }

        public DbSet<Cor> CorDbSet { get; set; }
        public DbSet<Produto> ProdutoDbSet { get; set; }
        public DbSet<ProdutoCor> ProdutoCorDbSet { get; set; }
        public DbSet<ProdutoEmEstoque> ProdutoEmEstoqueDbSet { get; set; }
        public DbSet<TipoProduto> TipoProdutoDbSet { get; set; }

        public DbSet<Venda> VendaDbSet { get; set; }
        public DbSet<Promissoria> PromissoriaDbSet { get; set; }
        public DbSet<VendaProdutoCor> VendaProdutoDbSet { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            Configuration.LazyLoadingEnabled = false;

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            #region [Configuração das entidades]

            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new FabricaConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpresaLocalConfiguration());
            modelBuilder.Configurations.Add(new FuncionarioConfiguration());
            modelBuilder.Configurations.Add(new ValeConfiguration());
            modelBuilder.Configurations.Add(new FinanceiraConfiguration());

            modelBuilder.Configurations.Add(new CorConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new ProdutoCorConfiguration());
            modelBuilder.Configurations.Add(new ProdutoEmEstoqueConfiguration());
            modelBuilder.Configurations.Add(new TipoProdutoConfiguration());

            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new PromissoriaConfiguration());
            modelBuilder.Configurations.Add(new VendaProdutoCorConfiguration());

            #endregion
        }

        private void FixEfProviderServicesProblem()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
