--Listar todos os clientes do estado de SP que possuem mais de 60% das parcelas pagas;


SELECT DISTINCT C.*, f.IdFinanciamento, f.ValorTotal, (SELECT SUM(ValorParcela) FROM Parcela WHERE IdFinanciamento = F.IdFinanciamento AND DataPagamento IS NOT NULL)
AS ValorPago
FROM Cliente C
JOIN Financiamento F ON C.CPF = F.CPF 
JOIN Parcela P ON P.IdFinanciamento = F.IdFinanciamento
WHERE UF = 'SP' 
AND (F.ValorTotal * 0.6 < (SELECT SUM(ValorParcela) FROM Parcela WHERE IdFinanciamento = F.IdFinanciamento AND DataPagamento IS NOT NULL))