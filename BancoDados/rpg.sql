CREATE DATABASE RPG
go
USE RPG

CREATE TABLE Usuarios (
		IdUsuario INT PRIMARY KEY IDENTITY,
		Email VARCHAR(100) UNIQUE NOT NULL,
		Password VARCHAR(100) NOT NULL
);

go
CREATE TABLE Classes(
	IdClasse INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)

go
CREATE TABLE Personagens(
	IdPersonagem INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(30) UNIQUE NOT NULL,
	IdUsuario INT UNIQUE FOREIGN KEY REFERENCES Usuarios(IdUsuario),
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
);


go
CREATE TABLE Habilidades(
	IdHabilidade INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(100) UNIQUE NOT NULL,
	Descricao VARCHAR(255)
)

go
CREATE TABLE ClasseHabilidade(
	IdClasse INT FOREIGN KEY REFERENCES Classes(IdClasse),
	IdHabilidade INT FOREIGN KEY REFERENCES Habilidades(IdHabilidade),
)

DROP TABLE ClasseHabilidade


--DML**********

INSERT INTO Usuarios(Password, Email) VALUES ('123456', 'email@email.com')
INSERT INTO Classes VALUES ('Mago','Utiliza poderes mágicos')
INSERT INTO Habilidades VALUES ('Bola de Fogo', 'Bola de fogo mortal'), ('Tornado de fogo', 'Tornado de foto mortal')
INSERT INTO Personagens(Nome, IdUsuario ,idClasse) VALUES ('JDOS',1,1)
INSERT INTO ClasseHabilidade (IdClasse, IdHabilidade) VALUES (1,1),(1,2)


INSERT INTO Usuarios(Password, Email) VALUES ('123456', 'email2@email.com')
INSERT INTO Classes VALUES ('Barbaro','Descrição Barbaro')
INSERT INTO Habilidades VALUES ('Recuperar Vida', 'Desriçao recuperar vida')
INSERT INTO Personagens(Nome, IdUsuario ,idClasse) VALUES ('BitBug',2,2)
INSERT INTO ClasseHabilidade (IdClasse,IdHabilidade) VALUES (2,2),(2,3)

--DQL*********

SELECT * FROM Usuarios

SELECT * FROM Classes
SELECT * FROM Personagens
SELECT * FROM Habilidades

SELECT * FROM ClasseHabilidade


SELECT * FROM Personagens
JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse
WHERE Personagens.IdClasse = 1

SELECT * FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse
WHERE Personagens.IdClasse = 1

SELECT Usuarios.Email, Personagens.Nome 'Nickname', Classes.Nome 'Classe' FROM Personagens
INNER JOIN Classes
ON Personagens.IdClasse = Classes.IdClasse
JOIN Usuarios
ON Personagens.IdUsuario = Usuarios.IdUsuario


SELECT Usuarios.Email, P.Nome 'Nickname', Classes.Nome 'Classe' FROM Personagens AS P
INNER JOIN Classes
ON P.IdClasse = Classes.IdClasse
JOIN Usuarios
ON P.IdUsuario = Usuarios.IdUsuario
