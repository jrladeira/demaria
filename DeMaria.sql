DROP PROCEDURE IF EXISTS cliente_inserir;
DROP PROCEDURE IF EXISTS cliente_alterar;
DROP PROCEDURE IF EXISTS cliente_excluir;

DROP PROCEDURE IF EXISTS produto_inserir;
DROP PROCEDURE IF EXISTS produto_alterar;
DROP PROCEDURE IF EXISTS produto_excluir;

DROP PROCEDURE IF EXISTS pedido_inserir;

DROP TABLE IF EXISTS pedido_item;
DROP TABLE IF EXISTS pedido;
DROP TABLE IF EXISTS produto;
DROP TABLE IF EXISTS cliente;

CREATE TABLE cliente
(
	cliente_id SERIAL NOT NULL,
	nome VARCHAR(60) NOT NULL,
	endereco VARCHAR(100) NOT NULL,
	telefone VARCHAR(20) NOT NULL,
	email VARCHAR(60) NOT NULL,
	CONSTRAINT pk_cliente PRIMARY KEY (cliente_id)
);

CREATE TABLE produto
(
	produto_id SERIAL NOT NULL,
	descricao VARCHAR(100) NOT NULL,
	preco DECIMAL NOT NULL,
	estoque INT NOT NULL,
	CONSTRAINT pk_produto PRIMARY KEY (produto_id)
);

CREATE TABLE pedido
(
	pedido_id SERIAL NOT NULL,
	cliente_id INT NOT NULL,
	pedido_data TIMESTAMP NOT NULL,
	quantidade_total INT NOT NULL,
	valor_total DECIMAL NOT NULL,
	CONSTRAINT pk_pedido PRIMARY KEY (pedido_id),
	CONSTRAINT fk_pedido_cliente FOREIGN KEY (cliente_id) REFERENCES cliente (cliente_id)
);

CREATE TABLE pedido_item
(
	pedido_item_id SERIAL NOT NULL,
	pedido_id INT NOT NULL,
	produto_id INT NOT NULL,
	quantidade INT NOT NULL,
	preco DECIMAL NOT NULL,
	valor_total DECIMAL NOT NULL,
	CONSTRAINT pk_pedido_item PRIMARY KEY (pedido_item_id),
	CONSTRAINT fk_pedido_item_pedido FOREIGN KEY (pedido_id) REFERENCES pedido (pedido_id),
	CONSTRAINT fk_pedido_item_produto FOREIGN KEY (produto_id) REFERENCES produto (produto_id)
);

CREATE PROCEDURE cliente_inserir
(
	p_nome VARCHAR(60),
	p_endereco VARCHAR(100),
	p_telefone VARCHAR(20),
	p_email VARCHAR(60),
	INOUT p_cliente_id INT DEFAULT NULL
)
LANGUAGE sql
AS $$
	INSERT INTO cliente (nome, endereco, telefone, email)
	VALUES (p_nome, p_endereco, p_telefone, p_email)
	RETURNING cliente_id;
$$;

CREATE PROCEDURE cliente_alterar
(
	p_cliente_id INT,
	p_nome VARCHAR(60),
	p_endereco VARCHAR(100),
	p_telefone VARCHAR(20),
	p_email VARCHAR(60)
)
LANGUAGE sql
AS $$
	UPDATE cliente SET
	nome = p_nome,
	endereco = p_endereco,
	telefone = p_telefone,
	email = p_email
	WHERE cliente_id = p_cliente_id;
$$;

CREATE PROCEDURE cliente_excluir (p_cliente_id INT)
LANGUAGE sql
AS $$
	DELETE FROM cliente WHERE cliente_id = p_cliente_id;
$$;

CREATE PROCEDURE produto_inserir
(
	p_descricao VARCHAR(100),
	p_preco DECIMAL,
	p_estoque INT,
	INOUT p_produto_id INT DEFAULT NULL
)
LANGUAGE sql
AS $$
	INSERT INTO produto (descricao, preco, estoque)
	VALUES (p_descricao, p_preco, p_estoque)
	RETURNING produto_id;
$$;

CREATE PROCEDURE produto_alterar
(
	p_produto_id INT,
	p_descricao VARCHAR(100),
	p_preco DECIMAL,
	p_estoque INT
)
LANGUAGE sql
AS $$
	UPDATE produto SET
	descricao = p_descricao,
	preco = p_preco,
	estoque = p_estoque
	WHERE produto_id = p_produto_id;
$$;

CREATE PROCEDURE produto_excluir (p_produto_id INT)
LANGUAGE sql
AS $$
	DELETE FROM produto WHERE produto_id = p_produto_id;
$$;

CREATE PROCEDURE pedido_inserir
(
	p_cliente_id INT,
	p_quantidade_total INT,
	p_valor_total DECIMAL,
	INOUT p_pedido_id INT DEFAULT NULL
)
LANGUAGE sql
AS $$
	INSERT INTO pedido (cliente_id, pedido_data, quantidade_total, valor_total)
	VALUES (p_cliente_id, CURRENT_TIMESTAMP, p_quantidade_total, p_valor_total)
	RETURNING pedido_id;
$$;
