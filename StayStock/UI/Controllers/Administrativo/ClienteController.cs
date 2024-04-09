using System.Web.Mvc;

namespace UI.Controllers.Administrativo
{
    public class ClienteController : BaseController
    {
        //private UnitOfWork unitOfWork = new UnitOfWork();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        { 
            #region [Testes CRUD]

            //Endereco endereco = new Endereco()
            //{
            //    Bairro = "Bairro 2",
            //    Rua = "Rua 2",
            //    Numero = "123 A 2 ",
            //    CEP = 330300302,
            //    Municipio = "Municipio 2"
            //};

            //Cliente cliente = new Cliente()
            //{
            //    ClienteEspecial = true,
            //    Inadimplente = false,
            //    Nome = "Mariazinha",
            //    Sexo = 'F',
            //    CodigoCpfCnpj = "CPF",
            //    Identidade = "Identidade",
            //    Telefone = "132",
            //    Email = "",
            //    DataNascimento = DateTime.Now.AddYears(-18),
            //    Endereco = endereco
            //};

            //Cor cor1 = new Cor()
            //{
            //    NomeCor = "Azul",
            //    CodigoHex = "#01ab92"
            //};

            //Fabrica fabrica = new Fabrica()
            //{
            //    CNPJ = "161.146.123/0191-01",
            //    Descricao = "Armarios de cozinha de aço",
            //    Email = "itatiaia@itatiaia.com.br",
            //    Endereco = unitOfWork.EnderecoRepository.GetByID(3),
            //    Nome = "Itatiaia"
            //};

            //Produto produto = new Produto()
            //{
            //    Nome = "Mesa de computador",
            //    ValorVenda = (decimal)156.90,
            //    Fabrica = fabrica
            //};

            //Funcionario func = new Funcionario()
            //{
            //    Nome = "Guilherme",
            //    DataNascimento = DateTime.Now.AddYears(-28),
            //    Sexo = 'M',
            //    Endereco = unitOfWork.EnderecoRepository.GetByID(1),
            //    IndicadorTipoFuncionario = TipoFuncionario.Montador,
            //    Salario = (decimal)2000.00,
            //    Senha = "123",
            //    CargaHoraria = "Seg a Sab",
            //    CodigoCpfCnpj = "123.456.789-01",
            //    NumeroPIS = 123456789,
            //    NumeroCarteiraTrabalho = 123468,
            //    Identidade = "MG-65.948.687-01",
            //    Telefone = "031 96874-9846"
            //};

            //Financeira financeira = new Financeira()
            //{
            //    Nome = "Losango",
            //    Login = "1",
            //    Usuario = "1",
            //    Descricao = "Losango",
            //    Senha = "123"
            //};

            //Vale vale = new Vale()
            //{
            //    Descricao = "Opcional",
            //    Valor = (decimal)50.00,
            //    FuncionarioVale = unitOfWork.FuncionarioRepository.GetByID(1)
            //};

            //TipoProduto tipo = new TipoProduto()
            //{
            //    Nome = "Colchao",
            //    Descricao = "Material utilizado: "
            //};

            #endregion


            //unitOfWork.Save();

            return RedirectToAction("Index", "Acesso");
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
