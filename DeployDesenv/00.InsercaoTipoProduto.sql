

INSERT INTO [dbo].[TipoProduto]
           ([Nome]
           ,[Descricao]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
		   --Quarto (Dormir)
           ('Colch�o Solteiro','Pode ser de mola ou n�o',GETDATE(),GETDATE(),NULL),
		   ('Colch�o Casal','Pode ser de mola ou n�o',GETDATE(),GETDATE(),NULL),
		   ('Colch�o Ber�o','Pode ser de mola ou n�o',GETDATE(),GETDATE(),NULL),
		   ('Cama Solteiro','',GETDATE(),GETDATE(),NULL),
		   ('Cama Casal','',GETDATE(),GETDATE(),NULL),
		   ('Ber�o','',GETDATE(),GETDATE(),NULL),
		   ('Box Solteiro','',GETDATE(),GETDATE(),NULL),
		   ('Box Casal','',GETDATE(),GETDATE(),NULL),
		   ('Cabeceira Box Casal','',GETDATE(),GETDATE(),NULL),
		   ('Cabeceira Box Solteiro','',GETDATE(),GETDATE(),NULL),
		   ('Beliche','',GETDATE(),GETDATE(),NULL),
		   ('Triliche','',GETDATE(),GETDATE(),NULL),
		   ('Cama Auxiliar','',GETDATE(),GETDATE(),NULL),
		   ('Travesseiro','',GETDATE(),GETDATE(),NULL),

		   --Quarto
		   ('Multiuso','',GETDATE(),GETDATE(),NULL),
		   ('C�moda','',GETDATE(),GETDATE(),NULL),
		   ('Guarda Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Criado Mudo','',GETDATE(),GETDATE(),NULL),
		   ('Sapateira','',GETDATE(),GETDATE(),NULL),
		   ('Penteadeira','',GETDATE(),GETDATE(),NULL),

		   --Sala de Estar
		   ('Mesa de Computador','',GETDATE(),GETDATE(),NULL),
		   ('Cadeira Girat�ria','',GETDATE(),GETDATE(),NULL),
		   ('Escrivaninha','',GETDATE(),GETDATE(),NULL),
		   ('Mesa de Centro','',GETDATE(),GETDATE(),NULL),
		   ('Aparador','Pode ser de ferro ou de madeira',GETDATE(),GETDATE(),NULL),
		   ('Ba�','',GETDATE(),GETDATE(),NULL),
		   ('Sof�','',GETDATE(),GETDATE(),NULL),
		   ('Rack','',GETDATE(),GETDATE(),NULL),
		   ('Painel','',GETDATE(),GETDATE(),NULL),
		   ('Estante','',GETDATE(),GETDATE(),NULL),

		   --Copa
		   ('Mesa 4 Cadeiras','',GETDATE(),GETDATE(),NULL),
		   ('Mesa 6 Cadeiras','',GETDATE(),GETDATE(),NULL),
		   ('Mesa Infantil','',GETDATE(),GETDATE(),NULL),
		   ('Cadeira Infantil','',GETDATE(),GETDATE(),NULL),
		   ('Poltrona','',GETDATE(),GETDATE(),NULL),
		   ('Poltrona Infantil','',GETDATE(),GETDATE(),NULL),

		   --Cozinha
		   ('Arm�rio Cozinha Madeira','Arm�rio com p� que n�o vai na parede',GETDATE(),GETDATE(),NULL),
		   ('Arm�rio Cozinha A�o','Arm�rio com p� que n�o vai na parede',GETDATE(),GETDATE(),NULL),
		   ('Paneleiro','Pode ser de a�o ou n�o',GETDATE(),GETDATE(),NULL),
		   ('Balc�o','Pode ser de a�o ou n�o',GETDATE(),GETDATE(),NULL),
		   ('Triplo','Pode ser de a�o ou n�o',GETDATE(),GETDATE(),NULL),

		   --El�tricos
		   ('Forno El�trico','',GETDATE(),GETDATE(),NULL),
		   ('Telefone','',GETDATE(),GETDATE(),NULL),
		   ('Sanduicheira','',GETDATE(),GETDATE(),NULL),
		   ('Ferro de Passar Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Batedeira','',GETDATE(),GETDATE(),NULL),
		   ('Liquidificador','',GETDATE(),GETDATE(),NULL),
		   ('M�quina de Lavar','',GETDATE(),GETDATE(),NULL),

		   --M�sica
		   ('Viol�o','',GETDATE(),GETDATE(),NULL),
		   ('Guitarra','',GETDATE(),GETDATE(),NULL),
		   ('Contrabaixo','',GETDATE(),GETDATE(),NULL),
		   ('Cavaquinho','',GETDATE(),GETDATE(),NULL),
		   ('Caixa de Som','',GETDATE(),GETDATE(),NULL),
		   ('Cordoamento','',GETDATE(),GETDATE(),NULL),
		   ('Afinador','',GETDATE(),GETDATE(),NULL),
		   ('Pedal','',GETDATE(),GETDATE(),NULL),

		   --Outros
		   ('Andador','',GETDATE(),GETDATE(),NULL),
		   ('Ventilador Ch�o','',GETDATE(),GETDATE(),NULL),
		   ('Ventilador Coluna','',GETDATE(),GETDATE(),NULL),
		   ('Tapete','',GETDATE(),GETDATE(),NULL),
		   ('Panela','',GETDATE(),GETDATE(),NULL),
		   ('Cadeira de Descanso','',GETDATE(),GETDATE(),NULL),
		   ('T�bua de Passar Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Puff','',GETDATE(),GETDATE(),NULL)