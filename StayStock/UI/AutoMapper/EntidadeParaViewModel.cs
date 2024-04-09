using Dominio.Entities.Administrativo;
using Dominio.Entities.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.Models.Administrativo;
using UI.Models.Estoque;

namespace UI.AutoMapper
{
    public static class EntidadeParaViewModel
    {
        public static FabricaViewModel Fabrica(Fabrica fabrica)
        {
            FabricaViewModel model = new FabricaViewModel
            {
                Identificador = fabrica.Identificador,
                Nome = fabrica.Nome,
                CNPJ = fabrica.CNPJ,
                Telefone = fabrica.Telefone,
                Email = fabrica.Email,
                Descricao = fabrica.Descricao,
                EstaAtivo = fabrica.DataHoraExclusao == null ? true : false,
                DataHoraInclusao = fabrica.DataHoraInclusao,
                DataHoraUltimaAlteracao = fabrica.DataHoraUltimaAlteracao,
                DataHoraExclusao = fabrica.DataHoraExclusao
            };

            if (fabrica.Endereco != null && fabrica.Endereco.Identificador != 0)
            {
                model.EnderecoViewModel = new EnderecoViewModel
                {
                    Identificador = fabrica.Endereco.Identificador,
                    CEP = Convert.ToUInt64(fabrica.Endereco.CEP.ToString()).ToString(@"00\.000\-000"),
                    Municipio = fabrica.Endereco.Municipio,
                    Bairro = fabrica.Endereco.Bairro,
                    Rua = fabrica.Endereco.Rua,
                    Numero = fabrica.Endereco.Numero
                };
            }

            return model;
        }

        public static List<FabricaViewModel> ListaFabrica(List<Fabrica> listaFabrica)
        {
            List<FabricaViewModel> listaRetorno = new List<FabricaViewModel>();

            foreach (Fabrica fabrica in listaFabrica)
            {
                listaRetorno.Add(Fabrica(fabrica));
            }

            return listaRetorno;
        }

        public static CorViewModel Cor(Cor cor)
        {
            CorViewModel model = new CorViewModel()
            {
                Identificador = cor.Identificador,
                NomeCor = cor.NomeCor,
                CodigoHex = cor.CodigoCor,
                Descricao = cor.Descricao,

                DataHoraInclusao = cor.DataHoraInclusao,
                DataHoraUltimaAlteracao = cor.DataHoraUltimaAlteracao,
                DataHoraExclusao = cor.DataHoraExclusao
            };

            return model;
        }

        public static List<CorViewModel> ListaCor(List<Cor> listaCor)
        {
            List<CorViewModel> listaRetorno = new List<CorViewModel>();

            foreach (Cor cor in listaCor)
            {
                listaRetorno.Add(Cor(cor));
            }

            return listaRetorno;
        }

        public static TipoProdutoViewModel TipoProduto(TipoProduto tipoProduto)
        {
            TipoProdutoViewModel model = new TipoProdutoViewModel()
            {
                Identificador = tipoProduto.Identificador,
                Nome = tipoProduto.Nome,
                Descricao = tipoProduto.Descricao,
                DataHoraInclusao = tipoProduto.DataHoraInclusao,
                DataHoraUltimaAlteracao = tipoProduto.DataHoraUltimaAlteracao,
                DataHoraExclusao = tipoProduto.DataHoraExclusao
            };

            return model;
        }

        public static List<TipoProdutoViewModel> ListaTipoProduto(List<TipoProduto> listaTipoProduto)
        {
            List<TipoProdutoViewModel> listaRetorno = new List<TipoProdutoViewModel>();

            foreach (TipoProduto tipoProduto in listaTipoProduto)
            {
                listaRetorno.Add(TipoProduto(tipoProduto));
            }

            return listaRetorno;
        }

        public static ProdutoViewModel Produto(Produto produto)
        {
            ProdutoViewModel model = new ProdutoViewModel()
            {
                Identificador = produto.Identificador,
                Nome = produto.Nome,
                NumeroSerie = produto.NumeroSerie,
                ValorVenda = produto.ValorVenda,

                IdentificadorTipoProduto = produto.TipoProduto.Identificador,
                TipoProdutoViewModel = TipoProduto(produto.TipoProduto),

                IdentificadorFabrica = produto.Fabrica.Identificador,
                FabricaViewModel = Fabrica(produto.Fabrica),

                DataHoraInclusao = produto.DataHoraInclusao,
                DataHoraUltimaAlteracao = produto.DataHoraUltimaAlteracao,
                DataHoraExclusao = produto.DataHoraExclusao
            };

            return model;
        }

        public static List<ProdutoViewModel> ListaProduto(List<Produto> listaProduto)
        {
            List<ProdutoViewModel> listaRetorno = new List<ProdutoViewModel>();

            foreach (Produto produto in listaProduto)
            {
                listaRetorno.Add(Produto(produto));
            }

            return listaRetorno;
        }

        public static ProdutoCorViewModel ProdutoCor(ProdutoCor produtoCor)
        {
            ProdutoCorViewModel model = new ProdutoCorViewModel()
            {
                Identificador = produtoCor.Identificador,

                IdentificadorProduto = produtoCor.IdentificadorProduto,
                ProdutoViewModel = Produto(produtoCor.Produto),

                DataHoraInclusao = produtoCor.DataHoraInclusao,
                DataHoraUltimaAlteracao = produtoCor.DataHoraUltimaAlteracao,
                DataHoraExclusao = produtoCor.DataHoraExclusao
            };

            if (produtoCor.Cor != null)
            {
                model.IdentificadorProduto = produtoCor.IdentificadorProduto;
                model.ProdutoViewModel = Produto(produtoCor.Produto);
            }

            return model;
        }

        public static List<ProdutoCorViewModel> ListaProdutoCor(List<ProdutoCor> listaProdutoCor)
        {
            List<ProdutoCorViewModel> listaRetorno = new List<ProdutoCorViewModel>();

            foreach (ProdutoCor produtoCor in listaProdutoCor)
            {
                listaRetorno.Add(ProdutoCor(produtoCor));
            }

            return listaRetorno;
        }

        public static ProdutoEmEstoqueViewModel ProdutoEmEstoque(ProdutoEmEstoque produtoEmEstoque)
        {
            ProdutoEmEstoqueViewModel model = new ProdutoEmEstoqueViewModel()
            {
                Identificador = produtoEmEstoque.Identificador,

                IdentificadorProdutoCor = produtoEmEstoque.IdentificadorProdutoCor,
                ProdutoCorViewModel = ProdutoCor(produtoEmEstoque.ProdutoCor),

                Quantidade = produtoEmEstoque.Quantidade,
                DataHoraInclusao = produtoEmEstoque.DataHoraInclusao,
                DataHoraUltimaAlteracao = produtoEmEstoque.DataHoraUltimaAlteracao,
                DataHoraExclusao = produtoEmEstoque.DataHoraExclusao
            };

            return model;
        }

        public static List<ProdutoEmEstoqueViewModel> ListaProdutoEstoque(List<ProdutoEmEstoque> listaProdutoEstoque)
        {
            List<ProdutoEmEstoqueViewModel> listaRetorno = new List<ProdutoEmEstoqueViewModel>();

            foreach (ProdutoEmEstoque produtoEstoque in listaProdutoEstoque)
            {
                listaRetorno.Add(ProdutoEmEstoque(produtoEstoque));
            }

            return listaRetorno;
        }

        public static ListarEstoqueViewModel ListarEstoque(ProdutoCor produtoCor)
        {
            ListarEstoqueViewModel model = new ListarEstoqueViewModel()
            {
                IdentificadorProdutoCor = produtoCor.Identificador,
                NomeProduto = produtoCor.Produto.Nome,
                NomeCor = produtoCor.Cor.NomeCor,
                TipoProduto = produtoCor.Produto.TipoProduto.Nome,
                Fabrica = produtoCor.Produto.Fabrica.Nome,
                QntdEstoque = produtoCor.ListaProdutosEmEstoque.FirstOrDefault().Quantidade.ToString(),
                DescricaoCor = produtoCor.Cor.Descricao
            };

            return model;
        }

        public static List<ListarEstoqueViewModel> ListaDeListarEstoque(List<ProdutoCor> listaProdutoCor)
        {
            List<ListarEstoqueViewModel> listaRetorno = new List<ListarEstoqueViewModel>();

            foreach (ProdutoCor produtoCor in listaProdutoCor)
            {
                listaRetorno.Add(ListarEstoque(produtoCor));
            }

            return listaRetorno;
        }

        public static EstoqueProdutoViewModel EstoqueProduto(ProdutoCor produtoCor)
        {
            EstoqueProdutoViewModel model = new EstoqueProdutoViewModel()
            {
                NomeProduto = produtoCor.Produto.Nome,
                NumeroSerie = produtoCor.Produto.NumeroSerie,
                ValorVenda = produtoCor.Produto.ValorVenda.ToString(),

                IdentificadorTipoProduto = produtoCor.Produto.TipoProduto.Identificador,
                IdentificadorFabrica = produtoCor.Produto.Fabrica.Identificador
            };

            if (produtoCor.ListaProdutosEmEstoque != null)
            {
                CorQuantidadeViewModel corQuantidadeViewModel;

                foreach (ProdutoEmEstoque produtoEmEstoque in produtoCor.ListaProdutosEmEstoque)
                {
                    corQuantidadeViewModel = new CorQuantidadeViewModel
                    {
                        IdentificadorCor = produtoEmEstoque.ProdutoCor.IdentificadorCor != null ? produtoEmEstoque.ProdutoCor.IdentificadorCor : 0,
                        Quantidade = produtoEmEstoque.Quantidade,
                        Descricao = produtoEmEstoque.ProdutoCor.Descricao,
                        CodigoCor = produtoEmEstoque.ProdutoCor.Cor.CodigoCor
                    };

                    model.ListaCorQuantidade.Add(corQuantidadeViewModel);
                }
            }

            return model;
        }

    }
}
