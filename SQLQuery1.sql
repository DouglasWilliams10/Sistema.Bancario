CREATE TABLE Usuario
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Nome NVARCHAR(150) NOT NULL,
    Sobrenome NVARCHAR(150) NOT NULL,
    Senha NVARCHAR(255) NOT NULL,
    CPF NVARCHAR(11) NOT NULL UNIQUE,
    DataNascimento DATE NOT NULL
);

CREATE TABLE Conta
(
    NumeroConta INT IDENTITY(1001,1) PRIMARY KEY,
    Saldo DECIMAL(18,2) NOT NULL DEFAULT 0,
    UsuarioId INT NOT NULL UNIQUE,
    DataPrimeiroDeposito DATETIME NULL,

    CONSTRAINT FK_Conta_Usuario
        FOREIGN KEY (UsuarioId)
        REFERENCES Usuario(Id)
);

CREATE TABLE Extrato
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroConta INT NOT NULL,
    Tipo NVARCHAR(100) NOT NULL,
    Valor DECIMAL(18,2) NOT NULL,
    Saldo DECIMAL(18,2) NOT NULL,
    DataOperacao DATETIME NOT NULL DEFAULT(GETDATE()),

    CONSTRAINT FK_Extrato_Conta
        FOREIGN KEY (NumeroConta)
        REFERENCES Conta(NumeroConta)
);
