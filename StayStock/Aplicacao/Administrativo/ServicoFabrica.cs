using Dominio.Entities.Administrativo;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Aplicacao.Administrativo
{
    public class ServicoFabrica : ServicoBase<Fabrica>
    {
        private ServicoEndereco servicoEndereco;

        public ServicoFabrica()
        {
            servicoEndereco = new ServicoEndereco();
        }

        public void Incluir(Fabrica fabrica)
        {
            if (ValidouDuplicado(fabrica))
            {
                UOW.FabricaRepository.Insert(fabrica);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao inserir: Fábrica já inserida com esses dados!");
            }
        }

        public void Alterar(Fabrica fabricaAlterada)
        {
            if (ValidouDuplicado(fabricaAlterada))
            {
                Fabrica fabricaOriginal = AtualizaFabricaOriginal(fabricaAlterada);

                //Se já tinha endereço, tem que alterar separadamente
                if (fabricaOriginal.Endereco != null)
                {
                    servicoEndereco.Alterar(fabricaAlterada.Endereco);
                    //fabricaOriginal.Endereco = null;  //É necessário setar nulo nesse campo, para nao incluir um novo endereco no metodo Update(Fabrica)
                }
                else
                {
                    fabricaOriginal.Endereco = fabricaAlterada.Endereco;
                }

                UOW.FabricaRepository.Update(fabricaOriginal);
                UOW.Save();
            }
            else
            {
                throw new ServiceException("Erro encontrado ao alterar: Fábrica já inserida com esses dados!");
            }
        }

        public List<Fabrica> ObterTodosAtivosPorFiltro(Expression<Func<Fabrica, bool>> filter = null,
            Func<IQueryable<Fabrica>, IOrderedQueryable<Fabrica>> orderBy = null,
            string includeProperties = "")
        {
            //filter = filter.And(x => x.DataHoraExclusao == null);

            //return UOW.RetornaFabricas();
            return UOW.FabricaRepository.Get(filter, orderBy, includeProperties).ToList();
        }

        public Fabrica ObterPorId(int id)
        {
            return UOW.FabricaRepository.GetByID(id);
        }

        public Fabrica ObterPorIdComEndereco(int id)
        {
            Fabrica fabrica = UOW.FabricaRepository.GetByID(id);

            if (fabrica.EnderecoIdentificador != null && fabrica.EnderecoIdentificador != 0)
                fabrica.Endereco = UOW.EnderecoRepository.GetByID(fabrica.EnderecoIdentificador);

            return fabrica;
        }

        private bool ValidouDuplicado(Fabrica fabrica)
        {
            Fabrica fabricaOriginal = UOW.FabricaRepository.Get(x =>
                                            x.Nome == fabrica.Nome &&
                                            x.CNPJ == fabrica.CNPJ &&
                                            x.Identificador != fabrica.Identificador)
                                             .FirstOrDefault();

            //Se não tem essa fábrica já inserida, retorna validado
            if (fabricaOriginal == null)
                return true;
            else
                return false;
        }

        private Fabrica AtualizaFabricaOriginal(Fabrica fabricaAlterada)
        {
            Fabrica fabricaOriginal = ObterPorIdComEndereco(fabricaAlterada.Identificador);

            fabricaOriginal.Nome = fabricaAlterada.Nome;
            fabricaOriginal.CNPJ = fabricaAlterada.CNPJ;
            fabricaOriginal.Email = fabricaAlterada.Email;
            fabricaOriginal.Telefone = fabricaAlterada.Telefone;
            fabricaOriginal.Descricao = fabricaAlterada.Descricao;

            //if (fabricaAlterada.Endereco != null)
            //{
            //    fabricaOriginal.Endereco = fabricaAlterada.Endereco;
            //}

            return fabricaOriginal;
        }
    }
}
