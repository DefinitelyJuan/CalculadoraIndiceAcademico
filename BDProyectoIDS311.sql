CREATE DATABASE ProyectoIDS311;
Go

USE ProyectoIDS311
Go

CREATE TABLE Students (
	RegisterID uniqueidentifier PRIMARY KEY NOT NULL,
	StudentID int NOT NULL,
	SubjectID char(6) NOT NULL,
	SubjectName varchar(30) NOT NULL,
	Credits int NOT NULL,
	Grade char(2) NOT NULL
)


Use ProyectoIDS311
Go

CREATE TABLE Register (
	StudentID int IDENTITY(1,1) PRIMARY KEY,
	StName varchar(10),
	StSurname varchar(15),
	Career varchar(30),
	StPassword varchar(16)
)

Use ProyectoIDS311
Go

INSERT INTO Register (StName, StSurname, Career, StPassword) VALUES ( 'Victor','Toribio', 'Ingeniería de Software', 'klk')
go


