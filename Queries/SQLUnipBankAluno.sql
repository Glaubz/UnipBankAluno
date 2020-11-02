USE UnipBankAluno

--Criando tabelas no banco UnipBankAluno
CREATE TABLE cliente(
	cpf VARCHAR(11) NOT NULL PRIMARY KEY,
	nome VARCHAR(30),
	rua VARCHAR(30),
	nr_rua INT,
	renda DECIMAL(10,2),
	dt_nasc VARCHAR(10),
	CONSTRAINT unique_cpf UNIQUE(cpf)
);

CREATE TABLE acesso(
	idAcesso INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	usuario VARCHAR(30),
	senha VARCHAR(30),
);

CREATE TABLE conta(
	numeroConta VARCHAR(20) NOT NULL PRIMARY KEY,
	tipoConta VARCHAR(10),
	maxDinheiro DECIMAL(6,2),
	valorMensal DECIMAL(4,2),
);

CREATE TABLE tipoConta(
	id INT IDENTITY(1,1) PRIMARY KEY,
	nome VARCHAR(10),
);

--Adicionando regra de referenciar chave estrangeira id de tipoConta em conta
ALTER TABLE conta
ADD CONSTRAINT conta_tipoConta
FOREIGN KEY (tipoConta)
REFERENCES tipoConta(id)

SELECT * FROM cliente

--Colocando tipoConta como não nulo
ALTER TABLE conta ALTER COLUMN tipoConta INT NOT NULL

--Inserindo valores à coluna nome
INSERT INTO tipoConta (nome) VALUES ('Comum'), ('Popanca'), ('Especial')

--Alterando o nome de um valor com Update
UPDATE tipoConta SET nome = 'Poupanca' WHERE nome = 'Popanca'

--Alterado o tipo de um campo da tabela
ALTER TABLE cliente ADD conta VARCHAR(20)

--Associando numero de conta com a tabela cliente através de fk
ALTER TABLE cliente
ADD CONSTRAINT cliente_conta
FOREIGN KEY (conta)
REFERENCES conta(numeroConta)

--Adicionado coluna fk de idAcesso
ALTER TABLE cliente ADD idAcesso INT NOT NULL

--Referenciando fk idAcesso da tabela acesso
ALTER TABLE cliente
ADD CONSTRAINT cliente_acesso
FOREIGN KEY (idAcesso)
REFERENCES acesso(idAcesso)

INSERT INTO cliente (cpf, nome, rua, nr_rua, renda, dt_nasc)
	VALUES ('40400850042', 'matheus', 'rua olinda', 24, 1500, '14071969')

--Colocando o campo de idAcesso como nulo para que possa criar o usuário sem ainda haver um acesso
ALTER TABLE cliente ALTER COLUMN idAcesso INT NULL

--Inserindo uma conta com numero e tipo
UPDATE cliente SET conta = '10320-5' WHERE nome like 'matheus'
UPDATE cliente SET idAcesso = 1 WHERE nome like 'matheus'

INSERT INTO acesso (usuario, senha)
	VALUES ('glaubz', '123456')

--WHERE cpf like '40400850042'

SELECT * FROM cliente

SELECT usuario, senha FROM acesso WHERE usuario = 'glaubz'