CREATE TABLE [dbo].[Cliente]
(
		CPF varchar(11) PRIMARY KEY,
		Nome varchar(50) NOT NULL,
		UF varchar(2) NOT NULL,
		Celular varchar(11) NOT NULL
)
