INSERT INTO Cliente (CPF, Nome,UF,Celular) VALUES ('41214150151','Fabricio Docema','SP','11959511122')
INSERT INTO Financiamento (CPF, TipoFinanciamento,ValorTotal,DataUltimoVencimento) VALUES ('41214150151',1,10000,'2024-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,1,833.35,'2024-01-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,2,833.35,'2024-02-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,3,833.35,'2024-03-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,4,833.35,'2024-04-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,5,833.35,'2024-05-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,6,833.35,'2024-06-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,7,833.35,'2024-07-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,8,833.35,'2024-08-03 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,9,833.35,'2024-09-03 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,10,833.35,'2024-10-03 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,11,833.35,'2024-11-03 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,12,833.35,'2024-12-03 00:00:00',null);

UPDATE Parcela SET DataPagamento = GETDATE() WHERE IdFinanciamento = 1 AND NumeroParcela = 8;
UPDATE Parcela SET DataPagamento = GETDATE() WHERE IdFinanciamento = 1 AND NumeroParcela = 9;

INSERT INTO Cliente (CPF, Nome,UF,Celular) VALUES ('41212350151','Jessyca Oliveira','SP','11959511122')
INSERT INTO Financiamento (CPF, TipoFinanciamento,ValorTotal,DataUltimoVencimento) VALUES ('41212350151',1,500,'2024-09-05 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,1,50,'2023-12-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,2,50,'2024-01-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,3,50,'2024-02-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,4,50,'2024-03-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,5,50,'2024-04-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,6,50,'2024-05-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,7,50,'2024-06-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,8,50,'2024-07-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,9,50,'2024-08-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,10,50,'2024-09-05 00:00:00',null);

INSERT INTO Cliente (CPF, Nome,UF,Celular) VALUES ('41214350151','Fabricio Oliveira','SP','11959511122')
INSERT INTO Financiamento (CPF, TipoFinanciamento,ValorTotal,DataUltimoVencimento) VALUES ('41214350151',1,12000,'2024-09-05 00:00:00');
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,1,1200,'2023-12-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,2,1200,'2024-01-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,3,1200,'2024-02-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,4,1200,'2024-03-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,5,1200,'2024-04-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,6,1200,'2024-05-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,7,1200,'2024-06-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,8,1200,'2024-07-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,9,1200,'2024-08-05 00:00:00',null);
INSERT INTO Parcela (IdFinanciamento,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,10,1200,'2024-09-05 00:00:00',null);