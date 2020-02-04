CREATE DATABASE db_vismo;
USE db_vismo;

CREATE TABLE Usuario(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR(70) NOT NULL UNIQUE,
email NVARCHAR(50) NOT NULL UNIQUE,
senha NVARCHAR(30) NOT NULL,
nomePadrao NVARCHAR(70) NOT NULL UNIQUE,
senhaPadrao NVARCHAR(30) NOT NULL
);

CREATE TABLE Preferencias(
conexao CHAR(1),
r NVARCHAR(3),
g NVARCHAR(3),
b NVARCHAR(3),
codigoUsuario INT,

CONSTRAINT preferencias_usuario FOREIGN KEY (codigoUsuario)
REFERENCES Usuario (codigo)
);

CREATE TABLE Funcionario(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR(70),
cpf NVARCHAR(11) UNIQUE,
telefone NVARCHAR(11) UNIQUE,
codigoUsuario INT,

CONSTRAINT funcionario_usuario FOREIGN KEY (codigoUsuario)
REFERENCES Usuario (codigo)
);

CREATE TABLE Fornecedor(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL,
status NVARCHAR (20) NOT NULL,
codigoUsuario INT,

CONSTRAINT fornecedor_usuario FOREIGN KEY (codigoUsuario)
REFERENCES Usuario (codigo)
);

CREATE TABLE Produto(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
nome NVARCHAR (50) NOT NULL,
preco FLOAT NOT NULL,
qtd INT,
status NVARCHAR (20) NOT NULL,
codigoFornecedor INT,
codigoUsuario INT,

CONSTRAINT produto_fornecedor FOREIGN KEY (codigoFornecedor)
REFERENCES Fornecedor (codigo),

CONSTRAINT produto_usuario FOREIGN KEY (codigoUsuario)
REFERENCES Usuario (codigo)
);

CREATE TABLE Venda(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
data DATETIME NOT NULL,
valor FLOAT NOT NULL,
codigoUsuario INT,

CONSTRAINT venda_usuario FOREIGN KEY (codigoUsuario)
REFERENCES Venda (codigo),
);

CREATE TABLE Produto_Venda(
codigoVenda INT,
codigoProduto INT,
qtd INT NOT NULL,

CONSTRAINT pvenda_venda FOREIGN KEY (codigoVenda)
REFERENCES Venda (codigo),

CONSTRAINT pvenda_produto FOREIGN KEY (codigoProduto)
REFERENCES Produto (codigo),
);

CREATE TABLE Pagamento(
codigo INT NOT NULL PRIMARY KEY IDENTITY(1,1),
valor FLOAT NOT NULL,
descr TEXT NOT NULL,
prazo DATE NOT NULL,
status NVARCHAR(15) NOT NULL,
codigoFornecedor INT,

CONSTRAINT pagamento_fornecedor FOREIGN KEY (codigoFornecedor)
REFERENCES Fornecedor (codigo)
);