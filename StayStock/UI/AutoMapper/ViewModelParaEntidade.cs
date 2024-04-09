using Dominio.Entities.Administrativo;
using Dominio.Entities.Estoque;
using System;
using UI.Models.Administrativo;
using UI.Models.Estoque;

namespace UI.AutoMapper
{
    public static class ViewModelParaEntidade
    {
        public static Fabrica Fabrica(FabricaViewModel model)
        {
            Fabrica fabrica = new Fabrica
            {
                Identificador = model.Identificador,
                Nome = model.Nome,
                CNPJ = model.CNPJ,
                Telefone = model.Telefone,
                Email = model.Email,
                Descricao = model.Descricao,
                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            if (model.EnderecoViewModel?.CEP != null && model.EnderecoViewModel?.Municipio != null &&
                model.EnderecoViewModel?.Bairro != null && model.EnderecoViewModel?.Rua != null && model.EnderecoViewModel?.Numero != null)
            {
                int cep = Convert.ToInt32(model.EnderecoViewModel.CEP.Remove(5, 1));

                fabrica.Endereco = new Endereco
                {
                    Identificador = model.EnderecoViewModel.Identificador,
                    CEP = cep,
                    Municipio = model.EnderecoViewModel.Municipio,
                    Bairro = model.EnderecoViewModel.Bairro,
                    Rua = model.EnderecoViewModel.Rua,
                    Numero = model.EnderecoViewModel.Numero
                };
            }

            return fabrica;
        }

        public static Cor Cor(CorViewModel model)
        {
            Cor cor = new Cor()
            {
                Identificador = model.Identificador,
                NomeCor = model.NomeCor,
                CodigoCor = model.CodigoHex,
                Descricao = model.Descricao,
                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            return cor;
        }

        public static TipoProduto TipoProduto(TipoProdutoViewModel model)
        {
            TipoProduto tipoProduto = new TipoProduto()
            {
                Identificador = model.Identificador,
                Nome = model.Nome,
                Descricao = model.Descricao,
                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            return tipoProduto;
        }

        public static Produto Produto(ProdutoViewModel model)
        {
            Produto produto = new Produto()
            {
                Identificador = model.Identificador,
                Nome = model.Nome,
                NumeroSerie = model.NumeroSerie,
                ValorVenda = model.ValorVenda,

                IdentificadorFabrica = model.IdentificadorFabrica,
                Fabrica = Fabrica(model.FabricaViewModel),

                IdentificadorTipoProduto = model.IdentificadorTipoProduto,
                TipoProduto = TipoProduto(model.TipoProdutoViewModel),

                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            return produto;
        }

        public static ProdutoCor ProdutoCor(ProdutoCorViewModel model)
        {
            ProdutoCor produtoCor = new ProdutoCor()
            {
                Identificador = model.Identificador,

                IdentificadorProduto = model.IdentificadorProduto,
                Produto = Produto(model.ProdutoViewModel),

                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            if (model.CorViewModel != null)
            {
                produtoCor.IdentificadorProduto = model.IdentificadorProduto;
                produtoCor.Cor = Cor(model.CorViewModel);
            }

            return produtoCor;
        }

        public static ProdutoEmEstoque ProdutoEmEstoque(ProdutoEmEstoqueViewModel model)
        {
            ProdutoEmEstoque produtoEmEstoque = new ProdutoEmEstoque()
            {
                Identificador = model.Identificador,

                IdentificadorProdutoCor = model.IdentificadorProdutoCor,
                ProdutoCor = ProdutoCor(model.ProdutoCorViewModel),

                Quantidade = model.Quantidade,
                DataHoraInclusao = model.DataHoraInclusao,
                DataHoraUltimaAlteracao = model.DataHoraUltimaAlteracao,
                DataHoraExclusao = model.DataHoraExclusao
            };

            return produtoEmEstoque;
        }
    }
}
