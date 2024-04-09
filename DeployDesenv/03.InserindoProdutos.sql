

INSERT INTO [dbo].[Produto]
           ([Nome]
           ,[NumeroSerie]
           ,[ValorVenda]
           ,[IdentificadorTipoProduto]
           ,[IdentificadorFabrica]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           ('Multiuso Chile','156-95'
           ,249.99
           ,15,5
           ,GETDATE(),GETDATE(),NULL)


INSERT INTO [dbo].[ProdutoCor]
           ([IdentificadorCor]
           ,[IdentificadorProduto]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao]
           ,[Descricao])
     VALUES
           (1
           ,1
           ,GETDATE(),GETDATE(),NULL
           ,'Imbuia com preto')
