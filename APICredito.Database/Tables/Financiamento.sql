CREATE TABLE [dbo].[Financiamento]
(
	IdFinanciamento BIGINT IDENTITY(1,1) PRIMARY KEY,
	CPF varchar(11) FOREIGN KEY REFERENCES Cliente(CPF),
	TipoFinanciamento INT NOT NULL,
	ValorTotal decimal NOT NULL,
	DataUltimoVencimento DATETIME NOT NULL
)
