USE MatchWornItems;
GO

CREATE TABLE Categoria
(
	IdCategoria INT IDENTITY(1,1) PRIMARY KEY,

	Nome VARCHAR(75) NOT NULL UNIQUE
);

CREATE TABLE Utilizador
(
	NIB BIGINT PRIMARY KEY,

	PrimeiroNome VARCHAR(75) NOT NULL,
	UltimoNome VARCHAR(75) NOT NULL,
	Email VARCHAR(150) NOT NULL UNIQUE,
	NumeroTelemovel BIGINT NOT NULL UNIQUE,
	PalavraPasse VARCHAR(75) NOT NULL,
	Morada VARCHAR(75) NOT NULL,
);



CREATE TABLE ArtigoLeilao
(
	IdLeilao INT IDENTITY(1,1) PRIMARY KEY,

	TamanhoArtigo VARCHAR(75) NOT NULL,
	DataUsoArtigo DATE NOT NULL,
	NomeEquipaEventoArtigo VARCHAR(75) NOT NULL,
	NomeArtigo VARCHAR(75) NOT NULL,
	DescricaoArtigo TEXT,
	NumeroAutenticacaoArtigo INT NOT NULL UNIQUE,
	EstadoArtigo VARCHAR(75) NOT NULL,
	ImagemArtigo TEXT NOT NULL,

	NomeLeilao VARCHAR(75) NOT NULL,
	TaxaMinimaIncrementoLeilao DECIMAL(10,2) NOT NULL,
	DataFinalizacaoLeilao DATE NOT NULL,
	PrecoCompraAutomaticoLeilao DECIMAL(10,2) NOT NULL,
	PrecoBaseLeilao DECIMAL(10,2) NOT NULL,
	IdCategoria INT NOT NULL,
	IdVendedor BIGINT NOT NULL,
	EstadoLeilao VARCHAR(75) NOT NULL,

	FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria),
	FOREIGN KEY (IdVendedor) REFERENCES Utilizador(NIB)
);

CREATE TABLE Licitacao
(
	IdLicitacao INT IDENTITY(1,1) PRIMARY KEY,
	ValorLicitacao DECIMAL(10,2) NOT NULL,
	NIBComprador BIGINT NOT NULL,
	IdLeilao INT NOT NULL,
	DataLicitacao DATETIME NOT NULL,
	FOREIGN KEY (NIBComprador) REFERENCES Utilizador(NIB),
	FOREIGN KEY (IdLeilao) REFERENCES ArtigoLeilao(IdLeilao)
);


CREATE TABLE NumeroAutenticacaoValido
(
	NumeroAutenticacaoValido INT NOT NULL
);


CREATE TABLE Logs
(
	NIB BIGINT PRIMARY KEY,
	Status BIT NOT NULL,

	FOREIGN KEY (NIB) REFERENCES Utilizador(NIB)
);