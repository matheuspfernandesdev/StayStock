

INSERT INTO [dbo].[TipoProduto]
           ([Nome]
           ,[Descricao]
           ,[DataHoraInclusao]
           ,[DataHoraUltimaAlteracao]
           ,[DataHoraExclusao])
     VALUES
		   --Quarto (Dormir)
           ('Colchão Solteiro','Pode ser de mola ou não',GETDATE(),GETDATE(),NULL),
		   ('Colchão Casal','Pode ser de mola ou não',GETDATE(),GETDATE(),NULL),
		   ('Colchão Berço','Pode ser de mola ou não',GETDATE(),GETDATE(),NULL),
		   ('Cama Solteiro','',GETDATE(),GETDATE(),NULL),
		   ('Cama Casal','',GETDATE(),GETDATE(),NULL),
		   ('Berço','',GETDATE(),GETDATE(),NULL),
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
		   ('Cômoda','',GETDATE(),GETDATE(),NULL),
		   ('Guarda Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Criado Mudo','',GETDATE(),GETDATE(),NULL),
		   ('Sapateira','',GETDATE(),GETDATE(),NULL),
		   ('Penteadeira','',GETDATE(),GETDATE(),NULL),

		   --Sala de Estar
		   ('Mesa de Computador','',GETDATE(),GETDATE(),NULL),
		   ('Cadeira Giratória','',GETDATE(),GETDATE(),NULL),
		   ('Escrivaninha','',GETDATE(),GETDATE(),NULL),
		   ('Mesa de Centro','',GETDATE(),GETDATE(),NULL),
		   ('Aparador','Pode ser de ferro ou de madeira',GETDATE(),GETDATE(),NULL),
		   ('Baú','',GETDATE(),GETDATE(),NULL),
		   ('Sofá','',GETDATE(),GETDATE(),NULL),
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
		   ('Armário Cozinha Madeira','Armário com pé que não vai na parede',GETDATE(),GETDATE(),NULL),
		   ('Armário Cozinha Aço','Armário com pé que não vai na parede',GETDATE(),GETDATE(),NULL),
		   ('Paneleiro','Pode ser de aço ou não',GETDATE(),GETDATE(),NULL),
		   ('Balcão','Pode ser de aço ou não',GETDATE(),GETDATE(),NULL),
		   ('Triplo','Pode ser de aço ou não',GETDATE(),GETDATE(),NULL),

		   --Elétricos
		   ('Forno Elétrico','',GETDATE(),GETDATE(),NULL),
		   ('Telefone','',GETDATE(),GETDATE(),NULL),
		   ('Sanduicheira','',GETDATE(),GETDATE(),NULL),
		   ('Ferro de Passar Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Batedeira','',GETDATE(),GETDATE(),NULL),
		   ('Liquidificador','',GETDATE(),GETDATE(),NULL),
		   ('Máquina de Lavar','',GETDATE(),GETDATE(),NULL),

		   --Música
		   ('Violão','',GETDATE(),GETDATE(),NULL),
		   ('Guitarra','',GETDATE(),GETDATE(),NULL),
		   ('Contrabaixo','',GETDATE(),GETDATE(),NULL),
		   ('Cavaquinho','',GETDATE(),GETDATE(),NULL),
		   ('Caixa de Som','',GETDATE(),GETDATE(),NULL),
		   ('Cordoamento','',GETDATE(),GETDATE(),NULL),
		   ('Afinador','',GETDATE(),GETDATE(),NULL),
		   ('Pedal','',GETDATE(),GETDATE(),NULL),

		   --Outros
		   ('Andador','',GETDATE(),GETDATE(),NULL),
		   ('Ventilador Chão','',GETDATE(),GETDATE(),NULL),
		   ('Ventilador Coluna','',GETDATE(),GETDATE(),NULL),
		   ('Tapete','',GETDATE(),GETDATE(),NULL),
		   ('Panela','',GETDATE(),GETDATE(),NULL),
		   ('Cadeira de Descanso','',GETDATE(),GETDATE(),NULL),
		   ('Tábua de Passar Roupa','',GETDATE(),GETDATE(),NULL),
		   ('Puff','',GETDATE(),GETDATE(),NULL)