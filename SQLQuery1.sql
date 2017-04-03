select * from pessoas where Nome like ('D%')
select * from pessoas where Descricao like ('Funcionario')

select * from pedidoes
select * from PessoaPedidoes
select * from PedidoDetalhes

select * from produtoes


-- Working as required

SELECT
	CASE WHEN LEN(t1.Nome) = 0 THEN t1.Empresa ELSE t1.Nome +' '+t1.Sobrenome END AS Cliente,
	CASE WHEN LEN(t1.Nome) = 0 THEN t1.Cnpj ELSE t1.Cpf END AS 'CPF / CNPJ',
	t2.Nome +' '+t2.Sobrenome AS Funcionario,
	DataPedido, DataEntrega
FROM Pedidoes
INNER JOIN PessoaPedidoes AS b1 ON b1.Pedido_id = Pedidoes.Id
INNER JOIN Pessoas AS t1 ON t1.Id = b1.Pessoa_id
INNER JOIN PessoaPedidoes AS b2 ON b2.Pedido_id = Pedidoes.Id
INNER JOIN Pessoas AS t2 ON t2.Id = b2.Pessoa_id
WHERE t1.Descricao LIKE ('Cliente') AND t2.Descricao LIKE ('Funcionario')
ORDER BY t1.Nome






SELECT
	CASE WHEN LEN(t1.Nome) = 0 THEN t1.Empresa ELSE t1.Nome +' '+t1.Sobrenome END AS Cliente,
	CASE WHEN LEN(t1.Nome) = 0 THEN t1.Cnpj ELSE t1.Cpf END AS 'CPF / CNPJ',
	t2.Nome +' '+t2.Sobrenome AS Funcionario,
	DataPedido, DataEntrega, b1.Pedido_Id, Pedidoes.ValorTotal,
	pr1.Descricao, d1.Quantidade, d1.PrecoUnitario, d1.PrecoTotal
FROM Pedidoes
INNER JOIN PessoaPedidoes AS b1 ON b1.Pedido_id = Pedidoes.Id
INNER JOIN Pessoas AS t1 ON t1.Id = b1.Pessoa_id
INNER JOIN PessoaPedidoes AS b2 ON b2.Pedido_id = Pedidoes.Id
INNER JOIN Pessoas AS t2 ON t2.Id = b2.Pessoa_id
INNER JOIN PedidoDetalhes AS d1 ON d1.PedidoId = Pedidoes.Id
INNER JOIN Produtoes AS pr1 ON pr1.Id = d1.ProdutoId
WHERE t1.Descricao LIKE ('Cliente') AND t2.Descricao LIKE ('Funcionario')
ORDER BY t1.Nome



SELECT
	t1.Nome AS Cliente,
	COUNT(*)
FROM Pessoas AS t1
LEFT JOIN PessoaPedidoes AS b1 ON b1.Pessoa_id = t1.Id
WHERE t1.Descricao LIKE ('Cliente')
GROUP BY t1.Nome
