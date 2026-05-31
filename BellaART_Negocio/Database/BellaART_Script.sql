-- ================================================
-- Script de criação do Banco de Dados BellaART
-- Sistema de Gestão Comercial
-- ================================================

CREATE DATABASE BellaART;
GO

USE BellaART;
GO

-- Tabela de Usuários
CREATE TABLE Usuarios (
    ID       INT IDENTITY(1,1) PRIMARY KEY,
    Nome     VARCHAR(100) NOT NULL,
    Cargo    VARCHAR(50)  NOT NULL,
    Login    VARCHAR(50)  NOT NULL,
    Senha    VARCHAR(50)  NOT NULL,
    Admin    BIT          NOT NULL DEFAULT 0,
    Ativo    BIT          NOT NULL DEFAULT 1
);
GO

-- Inserir usuário administrador padrão
INSERT INTO Usuarios (Nome, Cargo, Login, Senha, Admin, Ativo)
VALUES ('Administrador', 'Admin', 'admin', '123', 1, 1);
GO

-- Tabela de Categorias
CREATE TABLE Categorias (
    ID    INT IDENTITY(1,1) PRIMARY KEY,
    Nome  VARCHAR(100) NOT NULL,
    Ativo BIT NOT NULL DEFAULT 1
);
GO

-- Tabela de Produtos
CREATE TABLE Produtos (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    IDCategoria     INT NOT NULL,
    Nome            VARCHAR(100)  NOT NULL,
    SKU             VARCHAR(50)   NOT NULL,
    Descricao       VARCHAR(500),
    Quantidade      INT           NOT NULL DEFAULT 0,
    ValorUnitario   DECIMAL(10,2) NOT NULL DEFAULT 0,
    CustoUnitario   DECIMAL(10,2) NOT NULL DEFAULT 0,
    Ativo           BIT           NOT NULL DEFAULT 1,
    FOREIGN KEY (IDCategoria) REFERENCES Categorias(ID)
);
GO

-- Tabela de Clientes
CREATE TABLE Clientes (
    ID       INT IDENTITY(1,1) PRIMARY KEY,
    Nome     VARCHAR(100) NOT NULL,
    CPFCNPJ  VARCHAR(20),
    Telefone VARCHAR(20),
    Email    VARCHAR(100),
    Endereco VARCHAR(200),
    Ativo    BIT NOT NULL DEFAULT 1
);
GO

-- Tabela de Impostos
CREATE TABLE Impostos (
    ID         INT IDENTITY(1,1) PRIMARY KEY,
    Nome       VARCHAR(100)  NOT NULL,
    Percentual DECIMAL(5,2)  NOT NULL DEFAULT 0,
    Ativo      BIT           NOT NULL DEFAULT 1
);
GO

-- Tabela de Vendas
CREATE TABLE Vendas (
    ID          INT IDENTITY(1,1) PRIMARY KEY,
    IDCliente   INT           NOT NULL,
    IDImposto   INT           NOT NULL,
    DataVenda   DATETIME      NOT NULL DEFAULT GETDATE(),
    ValorTotal  DECIMAL(10,2) NOT NULL DEFAULT 0,
    Ativo       BIT           NOT NULL DEFAULT 1,
    FOREIGN KEY (IDCliente)  REFERENCES Clientes(ID),
    FOREIGN KEY (IDImposto)  REFERENCES Impostos(ID)
);
GO

-- Tabela de Itens da Venda
CREATE TABLE VendaItens (
    ID              INT IDENTITY(1,1) PRIMARY KEY,
    IDVenda         INT           NOT NULL,
    IDProduto       INT           NOT NULL,
    Quantidade      INT           NOT NULL,
    ValorUnitario   DECIMAL(10,2) NOT NULL,
    Subtotal        DECIMAL(10,2) NOT NULL,
    FOREIGN KEY (IDVenda)    REFERENCES Vendas(ID),
    FOREIGN KEY (IDProduto)  REFERENCES Produtos(ID)
);
GO
