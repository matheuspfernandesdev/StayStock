
INSERT INTO [dbo].[ProdutoEmEstoque]
           ([IdentificadorProdutoCor]
           ,[Quantidade]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
           (1
           ,10
           ,GETDATE(),GETDATE(),NULL)
