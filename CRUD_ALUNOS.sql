CREATE DATABASE CRUD_Alunos
GO
USE CRUD_Alunos

CREATE TABLE CRUD_ALUNOS(

ID_ALUNO INT IDENTITY(1,1) NOT NULL,
NOME VARCHAR(100),
IDADE INT,
ENDERECO VARCHAR(100),
TELEFONE VARCHAR(100),
EMAIL VARCHAR(100),
CIDADE VARCHAR(100),
UF CHAR(2),
NOME_PAI VARCHAR(100),
NOME_MAE VARCHAR(100)

CONSTRAINT PK_ID_ALUNO PRIMARY KEY(ID_ALUNO)
);

CREATE TABLE ESTADO(
ID_ESTADO INT IDENTITY(1,1) NOT NULL,
UF CHAR(2),
NOME VARCHAR(100)

CONSTRAINT PK_ESTADO PRIMARY KEY(ID_ESTADO)
);

CREATE TABLE CIDADE(
ID_CIDADE INT IDENTITY(1,1) NOT NULL,
UF CHAR(2),
NOME VARCHAR(100)

CONSTRAINT PK_CIDADE PRIMARY KEY(ID_CIDADE)
);




