USE [StayStock.Desenv]

INSERT INTO [dbo].[Endereco]
           ([Bairro]
           ,[Rua]
           ,[Numero]
           ,[CEP]
           ,[Municipio]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Bairro 1'
           ,'Rua 1'
           ,'1'
		   ,33030030
           ,'Municipio 1'
           ,Getdate()
           ,Getdate()
           ,null),
           ('Bairro 2'
           ,'Rua 2'
           ,'2'
		   ,330353420
           ,'Municipio 2'
           ,Getdate()
           ,Getdate()
           ,null),
           ('Bairro 3'
           ,'Rua 3'
           ,'3'
		   ,33030030
           ,'Municipio 3'
           ,Getdate()
           ,Getdate()
           ,null)

INSERT INTO [dbo].[Cor]
           ([NomeCor]
           ,[CodigoHex]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Azul'
           ,'#B8C45F'
           ,Getdate()
           ,Getdate()
           ,NULL),

           ('Preto'
           ,'#B8C95A'
           ,Getdate()
           ,Getdate()
           ,NULL),

           ('Imbuia'
           ,'#E8C49F'
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[Cliente]
           ([ClienteEspecial]
           ,[Inadimplente]
           ,[EnderecoIdentificador]
           ,[Nome]
           ,[CodigoCpfCnpj]
           ,[Identidade]
           ,[Telefone]
           ,[Email]
           ,[DataNascimento]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (0
           ,1
           ,1
           ,'Raimundo'
           ,'136548917-05'
           ,'MG-19.615.148'
           ,'31 36419854'
           ,'raimundo@extramoveis.com'
           ,Getdate()
           ,Getdate()
           ,Getdate()
           ,NULL),
           (1
           ,0
           ,2
           ,'Maria'
           ,'136548917-05'
           ,'MG-19.615.148'
           ,'31 36419854'
           ,'maria@extramoveis.com'
           ,Getdate()
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[Funcionario]
           ([EnderecoIdentificador]
           ,[Senha]
           ,[CargaHoraria]
           ,[Salario]
           ,[NumeroPIS]
           ,[NumeroCarteiraTrabalho]
           ,[IndicadorTipoFuncionario]
           ,[Nome]
           ,[CodigoCpfCnpj]
           ,[Identidade]
           ,[Telefone]
           ,[Email]
           ,[DataNascimento]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (2
           ,'123'
           ,'Seg a Sex'
           ,1000
           ,Cast(615561651156 as bigint)
           ,0256
           ,2
           ,'Jonatas'
           ,'CPFJonatas'
           ,'IdentidadeJonatas'
           ,'31 5487 9851'
           ,'jonatas@extramoveis.com'
           ,Getdate()
           ,Getdate()
		   ,Getdate()
           ,NULL),
           (2
           ,'123'
           ,'Seg a Sex'
           ,1000
           ,Cast(615561651156 as bigint)
           ,0256
           ,2
           ,'Guilherme'
           ,'CPFGuilherme'
           ,'IdentidadeGuilherme'
           ,'31 5487 9851'
           ,'guilherme@extramoveis.com'
           ,Getdate()
           ,Getdate()
		   ,Getdate()
           ,NULL)

INSERT INTO [dbo].[TipoProduto]
           ([Nome]
           ,[Descricao]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Colchão'
           ,'Material Utilizado: '
           ,Getdate()
           ,Getdate()
           ,NULL),

		   ('Rack'
           ,'Material Utilizado: '
           ,Getdate()
           ,Getdate()
           ,NULL),

			('Mesa'
           ,'Material Utilizado: '
           ,Getdate()
           ,Getdate()
           ,NULL),
			('Roupeiro'
           ,'Material Utilizado: '
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[Fabrica]
           ([Nome]
           ,[EnderecoIdentificador]
           ,[CNPJ]
           ,[Email]
           ,[Descricao]
		   ,[Telefone]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Valdemoveis'
           ,3
           ,'5616115616'
           ,'valdemoveis@extramoveis.com'
           ,'Armarios de cozinha e outros'
		   ,'31 992109387'
           ,Getdate()
           ,Getdate()
           ,NULL),
		    ('Itatiaia'
           ,3
           ,'05649316'
           ,'itatiaia@extramoveis.com'
           ,'Armarios de cozinha de aço e outros'
		   ,'31 9863565416'
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[EmpresaLocal]
           ([RazaoSocial]
           ,[NomeFantasia]
           ,[CNPJ]
           ,[EnderecoIdentificador]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[IdentificadorFuncionarioGestor])
     VALUES
           ('Mobiliadora Exodo LTDA'
           ,'Extra moveis'
           ,'056-0206-0321/0001'
           ,1
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1)

INSERT INTO [dbo].[Produto]
           ([Nome]
           ,[NumeroSerie]
           ,[ValorVenda]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[IdentificadorFabrica]
           ,[IdentificadorTipoProduto])
     VALUES
           ('Colchão D45 Requinte Casal'
           ,16496
           ,969.00
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1
           ,1),
		   ('Rack Madri II'
           ,16496
           ,269.00
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1
           ,2),
		   ('Mesa 4 cadeiras 80x110'
           ,16496
           ,479.00
           ,Getdate()
           ,Getdate()
           ,NULL
           ,2
           ,3),
		   ('Roupeiro Castro 4 portas'
           ,16496
           ,699.00
           ,Getdate()
           ,Getdate()
           ,NULL
           ,2
           ,4)

INSERT INTO [dbo].[Vale]
           ([Valor]
           ,[Descricao]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[IdentificadorFuncionarioVale])
     VALUES
           (180.00
           ,'Compra um refrigerante Ti zé'
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1),
           (100.00
           ,'Dominguin tá cobrando'
           ,Getdate()
           ,Getdate()
           ,NULL
           ,2)

INSERT INTO [dbo].[Financeira]
           ([Nome]
           ,[Usuario]
           ,[Login]
           ,[Senha]
           ,[Descricao]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Losango'
           ,'136498001'
           ,'DASILVA'
           ,'123'
           ,'Somente para parcelamentos até 10 vezes'
           ,Getdate()
           ,Getdate()
           ,NULL)
   
INSERT INTO [dbo].[ProdutoCor]
           ([IdentificadorCor]
           ,[IdentificadorProduto]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (NULL
           ,1
           ,Getdate()
           ,GETDATE()
           ,NULL),
		   (NULL
           ,3
           ,Getdate()
           ,GETDATE()
           ,NULL),
		   (1
           ,2
           ,Getdate()
           ,GETDATE()
		   ,NULL),
           (2
           ,2
           ,GETDATE()
           ,Getdate()
           ,NULL),
		   (2
           ,4
           ,GETDATE()
           ,Getdate()
           ,NULL),
		   (3
           ,4
           ,GETDATE()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[ProdutoEmEstoque]
           ([IdentificadorProdutoCor]
           ,[Quantidade]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (1
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL),
		   (2
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL),
		   (3
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL),
		   (4
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL),
		   (5
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL),
		   (6
           ,10
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[Venda]
           ([EnderecoIdentificador]
           ,[Observacoes]
		   ,[ValorTotal]
           ,[TipoPagamento]
           ,[DataHoraEntrega]
           ,[QuantidadePromissoria]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[IdentificadorCliente]
           ,[IdentificadorFuncionario])
     VALUES
           (NULL
           ,'Perto do supermacado XPTO'
		   ,1234
           ,2
           ,GETDATE()
           ,3
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1
           ,1)
		   ,
           (3
           ,'Perto do supermacado XPTO'
           ,1234
		   ,2
           ,GETDATE()
           ,0
           ,Getdate()
           ,Getdate()
           ,NULL
           ,2
           ,2)

INSERT INTO [dbo].[VendaProdutoCor]
           ([IdentificadorVenda]
           ,[IdentificadorProdutoCor]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (1
           ,1
           ,Getdate()
           ,Getdate()
           ,NULL),
           (1
           ,2
           ,Getdate()
           ,Getdate()
           ,NULL),           
		   (2
           ,3
           ,Getdate()
           ,Getdate()
           ,NULL),           
		   (2
           ,4
           ,Getdate()
           ,Getdate()
           ,NULL)

INSERT INTO [dbo].[Promissoria]
           ([DataVencimento]
           ,[Valor]
           ,[ValorPorExtenso]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[IdentificadorVenda])
     VALUES
           (Getdate()
           ,100
           ,'Cem bonoros'
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1),
		    (Getdate()
           ,100
           ,'Cem bonoros'
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1),
		    (Getdate()
           ,100
           ,'Cem bonoros'
           ,Getdate()
           ,Getdate()
           ,NULL
           ,1)
