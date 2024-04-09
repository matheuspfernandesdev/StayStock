using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Estoque
{
    public class ServicoProdutoEstoque : ServicoBase<ProdutoEmEstoque>
    {
        //public void Incluir(ProdutoEmEstoque produtoEmEstoque)
        //{
        //    if (ValidouDuplicado(produtoEmEstoque))
        //    {
        //        UOW.ProdutoEmEstoqueRepository.Insert(produtoEmEstoque);
        //        UOW.Save();
        //    }
        //    else
        //    {
        //        //throw new ServiceException("Erro encontrado ao inserir: Fábrica já inserida com esses dados!");
        //    }
        //}

        //public void Alterar(ProdutoEmEstoque produtoEmEstoque)
        //{
        //    if (ValidouDuplicado(produtoEmEstoque))
        //    {
        //        ProdutoEmEstoque produtoEmEstoqueOriginal = AtualizaFabricaOriginal(produtoEmEstoque);

        //        UOW.FabricaRepository.Update(produtoEmEstoqueOriginal);
        //        UOW.Save();
        //    }
        //    else
        //    {
        //        throw new ServiceException("Erro encontrado ao alterar: Fábrica já inserida com esses dados!");
        //    }
        //}

        public List<ProdutoEmEstoque> ObterTodosAtivosPorFiltro(Expression<Func<ProdutoEmEstoque, bool>> filter = null,
            Func<IQueryable<ProdutoEmEstoque>, IOrderedQueryable<ProdutoEmEstoque>> orderBy = null,
            string includeProperties = "")
        {
            //filter = filter.And(x => x.DataHoraExclusao == null);

            //return UOW.RetornaFabricas();
            return UOW.ProdutoEmEstoqueRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public ProdutoEmEstoque ObterPorId(int id)
        {
            return UOW.ProdutoEmEstoqueRepository.GetByID(id);
        }

        //private bool ValidouDuplicado(Fabrica fabrica)
        //{
        //    Fabrica fabricaOriginal = UOW.FabricaRepository.Get(x =>
        //                                    x.Nome == fabrica.Nome &&
        //                                    x.CNPJ == fabrica.CNPJ &&
        //                                    x.Identificador != fabrica.Identificador)
        //                                     .FirstOrDefault();

        //    //Se não tem essa fábrica já inserida, retorna validado
        //    if (fabricaOriginal == null)
        //        return true;
        //    else
        //        return false;
        //}

        //private Fabrica AtualizaFabricaOriginal(Fabrica fabricaAlterada)
        //{
        //    Fabrica fabricaOriginal = ObterPorIdComEndereco(fabricaAlterada.Identificador);

        //    fabricaOriginal.Nome = fabricaAlterada.Nome;
        //    fabricaOriginal.CNPJ = fabricaAlterada.CNPJ;
        //    fabricaOriginal.Email = fabricaAlterada.Email;
        //    fabricaOriginal.Telefone = fabricaAlterada.Telefone;
        //    fabricaOriginal.Descricao = fabricaAlterada.Descricao;

        //    return fabricaOriginal;
        //}

    }
}
