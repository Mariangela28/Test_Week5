CREATE DATABASE Esami

CREATE TABLE Studente(
ID INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(50) NOT NULL,
Cognome VARCHAR (50) NOT NULL,
AnnoNascita INT NOT NULL,
UNIQUE (ID, Nome, Cognome)
)

CREATE TABLE Esame(
ID INT IDENTITY(1,1) PRIMARY KEY,
Nome VARCHAR(50) NOT NULL,
CFU INT NOT NULL,
DataEsame DATETIME NOT NULL,
Votazione INT NOT NULL,
Passato VARCHAR NOT NULL,
StudenteID INT NOT NULL,
FOREIGN KEY (StudenteID) REFERENCES Studente(ID),
CHECK( Passato IN ('Promosso', 'Bocciato'))
)
ALTER TABLE Esame ALTER COLUMN Passato VARCHAR(50)


INSERT INTO Studente VALUES ('Fabio', 'Rossi', 1996)
INSERT INTO Studente VALUES ('Marzo', 'Pilli', 1995)
INSERT INTO Studente VALUES ('Cristina', 'Verdi', 2000)
INSERT INTO Studente VALUES ('Maria', 'Mango', 1997)
SELECT * FROM Studente
INSERT INTO Esame VALUES ('Bioelettromagnetismo', 12, '2019-07-01', 25, 'Promosso', 1)
INSERT INTO Esame VALUES ('Biomeccanica', 12, '2021-07-23', 23, 'Promosso', 2)
INSERT INTO Esame VALUES ('Informatica', 10, '2018-06-30', 27, 'Bocciato', 3)
INSERT INTO Esame VALUES ('Statistica', 9, '2018-09-05', 18, 'Bocciato', 4)
SELECT * FROM Esame
