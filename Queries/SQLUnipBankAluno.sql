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

CREATE PROCEDURE SP_InsertClient
	@SP_cpf VARCHAR(11),
	@SP_nome VARCHAR(30),
	@SP_rua VARCHAR(30),
	@SP_nr_rua INT,
	@SP_dt_nasc VARCHAR(10),
	@SP_renda DECIMAL(10,2),
	@SP_numConta VARCHAR(20),
	@SP_tipoConta INT,
	@SP_maxDinheiro DECIMAL(8,2) = 0,
	@SP_valorMensal DECIMAL(4,2) = 0,
	@SP_usuario VARCHAR(30),
	@SP_senha VARCHAR(30)
	
	AS

	--Condi��es para definir as configura��es de cada tipo de conta --Deu certo nao, dps vejo TODO
	IF @SP_tipoConta = 1
		BEGIN
			SET @SP_maxDinheiro = 5000.00;
			SET @SP_valorMensal = 15.00;
		END
	ELSE IF @SP_tipoConta = 2
		BEGIN
			SET @SP_maxDinheiro = 10000.00;
			SET @SP_valorMensal = 50.00;
		END
	ELSE
		BEGIN
			SET @SP_maxDinheiro = 1000000.00;
			SET @SP_valorMensal = 100.00;
		END

	INSERT INTO conta(numeroConta, tipoConta, saldo)
	VALUES (@SP_numConta, @SP_tipoConta, 0);
	--SELECT @SP_numConta = @@IDENTITY
	INSERT INTO acesso(usuario, senha)
	VALUES (@SP_usuario, @SP_senha);
	DECLARE @SP_idAcesso INT = SCOPE_IDENTITY();
	INSERT INTO cliente (cpf, nome, rua, nr_rua, dt_nasc, renda, conta, idAcesso)
	VALUES (@SP_cpf, @SP_nome, @SP_rua, @SP_nr_rua, @SP_dt_nasc, @SP_renda, @SP_numConta, @SP_idAcesso);
	RETURN

--Excluir Procedure do banco
DROP PROCEDURE SP_InsertClient;

--Vendo clientes e contas
SELECT * FROM cliente cl 
JOIN conta c ON cl.conta = c.numeroConta
JOIN acesso ac ON ac.idAcesso = cl.idAcesso

SELECT * FROM cliente
SELECT * FROM conta

--Colocando tipoConta como n�o nulo
ALTER TABLE conta ALTER COLUMN tipoConta INT NOT NULL

--Inserindo valores � coluna nome
INSERT INTO tipoConta (nome) VALUES ('Comum'), ('Poupanca'), ('Especial')

--Alterando o nome de um valor com Update
UPDATE tipoConta SET nome = 'Poupanca' WHERE nome = 'Popanca'

--Alterado o tipo de um campo da tabela
ALTER TABLE cliente ADD conta VARCHAR(20)

--Associando numero de conta com a tabela cliente atrav�s de fk
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

--Colocando o campo de idAcesso como nulo para que possa criar o usu�rio sem ainda haver um acesso
ALTER TABLE cliente ALTER COLUMN idAcesso INT NULL

--Inserindo uma conta com numero e tipo
UPDATE cliente SET conta = '10320-5' WHERE nome like 'matheus'
UPDATE cliente SET idAcesso = 1 WHERE nome like 'matheus'

INSERT INTO acesso (usuario, senha)
	VALUES ('glaubz', '123456')

--WHERE cpf like '40400850042'

SELECT * FROM cliente

SELECT usuario, senha FROM acesso WHERE usuario = 'glaubz'

ALTER TABLE conta ADD saldo DECIMAL(8,2)

ALTER TABLE conta ALTER COLUMN maxDinheiro DECIMAL(9,2)
ALTER TABLE conta ALTER COLUMN valorMensal DECIMAL(5,2)

UPDATE conta SET maxDinheiro = 1000000.00 WHERE numeroConta = '10100-5'

--Procedure para pegar dado completo do cliente
--CREATE PROCEDURE SP_InsertInCode
--	@Login VARCHAR(30)
--	AS
	SELECT cl.cpf, cl.nome, cl.nr_rua, cl.renda, cl.dt_nasc,
	ac.idAcesso, ac.usuario, 
	co.numeroConta, co.tipoConta, co.valorMensal, co.maxDinheiro, co.saldo
	FROM cliente cl
	JOIN acesso ac ON ac.idAcesso = cl.idAcesso
	JOIN conta co ON co.numeroConta = cl.conta
	WHERE ac.usuario like 'mago' --@Login

DROP PROCEDURE SP_InsertInCode

--verificar dados importantes da conta e usar para verificar transferencia
SELECT cl.cpf, cl.nome, cl.nr_rua, cl.rua, cl.renda, cl.dt_nasc,
ac.idAcesso, ac.usuario, 
co.numeroConta, co.tipoConta, co.valorMensal, co.maxDinheiro, co.saldo
FROM cliente cl
JOIN acesso ac ON ac.idAcesso = cl.idAcesso
JOIN conta co ON co.numeroConta = cl.conta
WHERE ac.usuario like 'mago'
OR ac.usuario like 'glaubz'

--Query para pegar infos da conta com o login de parametro
SELECT co.numeroConta, co.tipoConta, co.maxDinheiro, co.valorMensal, co.saldo
FROM conta co
JOIN cliente cl ON co.numeroConta = cl.conta
JOIN acesso ac ON ac.idAcesso = cl.idAcesso
WHERE ac.usuario = 'mago'

SELECT co.* FROM conta co
JOIN cliente cl ON cl.conta = co.numeroConta
JOIN acesso ac ON ac.idAcesso = cl.idAcesso
WHERE ac.usuario = 'mago'

--valida destinatario
SELECT ac.usuario, cl.nome FROM acesso ac
JOIN cliente cl ON cl.idAcesso = ac.idAcesso
WHERE ac.usuario = @destinatario
OR cl.nome = @destinatario

--criando tabela para colocar os logs
CREATE TABLE logs(
	log VARCHAR(100)
	);
--esqueci do id pk
ALTER TABLE logs ADD id INT NOT NULL IDENTITY(1,1) PRIMARY KEY

ALTER TABLE conta ADD idLogs INT

ALTER TABLE conta
ADD CONSTRAINT conta_logs
FOREIGN KEY (idLogs)
REFERENCES logs(id)

--Deletando a tabela de logs, taquei listinha
DROP TABLE logs