CREATE DATABASE AB104Relation

USE AB104Relation

CREATE TABLE Universities(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL UNIQUE,
)

CREATE TABLE Subjects(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL UNIQUE,
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
Surname NVARCHAR(25) DEFAULT 'XXX',
UniversityId INT REFERENCES Universities(Id)
)

--CREATE TABLE StudentSubjects(

--)


INSERT INTO Students VALUES(N'Zülfiyyə',N'Qurbanova',2)

SELECT s.Name, u.Name AS [University Name] FROM Students AS s
FULL OUTER JOIN Universities AS u
ON s.UniversityId=u.Id
WHERE s.UniversityId IS NULL



CREATE TABLE Employees(
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) NOT NULL,
DependId INT REFERENCES Employees(Id)
)


SELECT Employees.Name, Depend.Name as [Depend on] FROM Employees
LEFT JOIN Employees AS Depend
ON Employees.DependId=Depend.Id