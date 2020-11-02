

USE UnipBankProf

CREATE TABLE cliente(
	id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	cpf VARCHAR(11) NOT NULL,
	nome VARCHAR(30),
	rua VARCHAR(30),
	nr_rua INT,
	dt_nasc VARCHAR(10),
	renda DECIMAL(10,2),
	CONSTRAINT unique_cpf UNIQUE(cpf)
);

GO

CREATE PROCEDURE SP_InsertCliente
	@SP_cpf VARCHAR(11),
	@SP_nome VARCHAR(30),
	@SP_rua VARCHAR(30),
	@SP_nr_rua INT,
	@SP_dt_nasc VARCHAR(10),
	@SP_renda DECIMAL(10,2)
	AS
	INSERT INTO cliente (cpf, nome, rua, nr_rua, dt_nasc, renda)
	VALUES (@SP_cpf, @SP_nome, @SP_rua, @SP_nr_rua, @SP_dt_nasc, @SP_renda);
	RETURN
	
DROP PROCEDURE SP_InsertCliente;

SELECT * FROM cliente