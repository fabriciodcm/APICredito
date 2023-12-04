CREATE TABLE [dbo].[Parcela]
(
	IdParcela BIGINT IDENTITY(1,1) PRIMARY KEY,
	IdFinanciamento BIGINT FOREIGN KEY REFERENCES Financiamento(IdFinanciamento),
	NumeroParcela INT NOT NULL,
	ValorParcela decimal NOT NULL,
	DataVencimento DATETIME NOT NULL,
	DataPagamento DATETIME
)
