
CREATE DATABASE AB104

USE AB104

CREATE TABLE Students
(
   Id int PRIMARY KEY IDENTITY,
   [Name] varchar(25) NOT NULL,
   Surname varchar(25) DEFAULT 'XXX',
   Age int CHECK(Age>=0 and Age<=100),
   Email varchar(250) UNIQUE
)
DROP TABLE Students




--ALTER TABLE Students ADD FName varchar(25)
--ALTER TABLE Students DROP COLUMN FName


INSERT INTO Students VALUES
('Sabuhi2','Camalzade',19,'Ibrahim')
,('Leyla','Shafiyeva',19,'Dursun')

INSERT INTO Students(Name,Email,Age) VALUES('Adil','adil@gmail.com',19)

--UPDATE Students SET Surname='XXX' WHERE Age>19 and Age<22

--DELETE FROM Students WHERE Id=2


--SELECT Name, Surname FROM Students WHERE Name like '_a%' 



