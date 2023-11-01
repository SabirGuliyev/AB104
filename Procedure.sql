CREATE DATABASE AB104Procedure

USE AB104Procedure

CREATE TABLE Groups(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(10) NOT NULL
)

CREATE TABLE Students(
Id INT PRIMARY KEY IDENTITY,
Name VARCHAR(25) NOT NULL,
Surname VARCHAR(25) DEFAULT 'XXX',
Point	INT CHECK(Point BETWEEN 0 AND 100),
GroupId INT REFERENCES Groups(Id),
IsDeleted BIT
)

ALTER TABLE Students ADD IsDeleted2 BIT NOT NULL

--CREATE VIEW GetStudentsPoint
--AS
--SELECT s.Name+' '+s.Surname AS Fullname,s.Point,g.Name AS [Group] FROM Students AS s
--JOIN Groups AS g
--ON s.GroupId=g.Id


--SELECT * FROM GetStudentsPoint
--WHERE Point>80

--SELECT * FROM GetStudentsPoint
--WHERE Point>90

--CREATE PROCEDURE usp_GetStudentByPoint @point INT,@group VARCHAR(10)
--AS
--SELECT * FROM GetStudentsPoint
--WHERE Point>@point AND [Group]=@group

--EXEC usp_GetStudentByPoint 70,'AB104'

--EXEC usp_GetStudentByPoint 80

--EXEC usp_GetStudentByPoint 90


CREATE FUNCTION Capitalize(@word VARCHAR(25))
RETURNS VARCHAR(25)
AS
BEGIN
--DECLARE @capital VARCHAR(25)
SET @word=UPPER(LEFT(@word,1))+LOWER(SUBSTRING(@word,2,LEN(@word)))
RETURN @word
END




CREATE PROCEDURE usp_CreateStudent(@name VARCHAR(25),@point INT,@groupId INT,@surname VARCHAR(25)='XXX')
AS
EXEC @name=Capitalize @word=@name
EXEC @surname=Capitalize @word=@surname
INSERT INTO Students VALUES(@name,@surname,@point,@groupId)


EXEC usp_CreateStudent 'adil',86,1,'nasirli'


DECLARE @capital VARCHAR(25)

PRINT @capital


CREATE FUNCTION GetStudentsCount(@point INT)
RETURNS INT
BEGIN
DECLARE @studentCount INT

SELECT @studentCount= COUNT(*) FROM Students WHERE Point>@point
RETURN @studentCount
END


SELECT dbo.GetStudentsCount(90)


ALTER TRIGGER GetStudentsAfterDelete
ON Students
INSTEAD OF DELETE
AS
DECLARE @result BIT
DECLARE @id INT
SELECT @result=IsDeleted,@id=deleted.Id FROM deleted
IF(@result=0)
 BEGIN
 UPDATE Students SET IsDeleted=1 WHERE Id=@id
 END
ELSE
 BEGIN
 DELETE FROM Students WHERE Id=@id
END


DELETE FROM Students WHERE Id=2