
CREATE DATABASE AB104View

USE AB104View

CREATE TABLE KHProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL,
Price DECIMAL(6,2) NOT NULL
)
CREATE TABLE IrshadProducts(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(100) NOT NULL,
Price DECIMAL(6,2) NOT NULL
)

CREATE TABLE Clothes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(50) NOT NULL,
)

CREATE TABLE Sizes(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(25) NOT NULL,
)

CREATE TABLE ClotheSizes(
Id INT PRIMARY KEY IDENTITY,
ClotheId INT FOREIGN KEY REFERENCES Clothes(Id),
SizeId INT FOREIGN KEY REFERENCES Sizes(Id)
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(25) NOT NULL,
Surname VARCHAR(25) DEFAULT 'XXX',
Point INT CHECK(Point BETWEEN 0 and 100)
)

CREATE TABLE Grades(
Id INT PRIMARY KEY IDENTITY,
Letter CHAR(1) NOT NULL,
MinGrade INT CHECK(MinGrade BETWEEN 0 AND 100),
MaxGrade INT CHECK(MaxGrade BETWEEN 0 AND 100)
)

CREATE VIEW GetClothesSizes
AS
SELECT c.Id, c.Name,s.Name Size FROM Clothes as c
JOIN ClotheSizes as cs
ON c.Id=cs.ClotheId
JOIN Sizes as s
ON cs.SizeId=s.Id


SELECT c.Id, c.Name,s.Name Size FROM Clothes as c
JOIN ClotheSizes as cs
ON c.Id=cs.ClotheId
JOIN Sizes as s
ON cs.SizeId=s.Id
WHERE LEN(c.Name)>5

SELECT c.Id, c.Name,s.Name Size FROM Clothes as c
JOIN ClotheSizes as cs
ON c.Id=cs.ClotheId
JOIN Sizes as s
ON cs.SizeId=s.Id
WHERE c.Name='T-Shirt'

SELECT * FROM GetClothesSizes WHERE Name='T-Shirt'
SELECT * FROM GetClothesSizes WHERE LEN(Name)>5

--WHERE LEN(s.Name)>3
--GROUP BY c.Name, c.Id
--HAVING COUNT(s.Name)>4






--SELECT c.Name,s.Name 'Size name' FROM Clothes AS c
--CROSS JOIN Sizes AS s


CREATE VIEW GetStudentGrades
AS
SELECT s.Name +' '+s.Surname as First,s.Point ,g.Letter as GradeClassification FROM Students as s
JOIN Grades as g
ON s.Point BETWEEN g.MinGrade and g.MaxGrade


SELECT * FROM (SELECt * FROM GetStudentGrades )
AS r
WHERE r.Point>70



SELECT * FROM Students AS  S

SELECT * FROM (SELECT * FROM Students WHERE Point>50) AS r
WHERE LEN(r.Name)>5



--SELECT Name, Price FROM KHProducts
--UNION 
--SELECT Name, Price FROM IrshadProducts

--SELECT Name FROM KHProducts
--INTERSECT 
--SELECT Name FROM IrshadProducts


--SELECT Name FROM IrshadProducts
--EXCEPT 
--SELECT Name FROM KHProducts