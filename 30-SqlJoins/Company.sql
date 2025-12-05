CREATE DATABASE Company; GO

USE Company; GO

CREATE TABLE Countries ( Id INT PRIMARY KEY IDENTITY(1,1), Name
NVARCHAR(50) );

CREATE TABLE Cities ( Id INT PRIMARY KEY IDENTITY(1,1), Name
NVARCHAR(50), CountryId INT FOREIGN KEY REFERENCES Countries(Id) );

CREATE TABLE Employees ( Id INT PRIMARY KEY IDENTITY(1,1), Name
NVARCHAR(50), Surname NVARCHAR(50), Age INT, Salary DECIMAL(10,2),
Position NVARCHAR(50), CityId INT FOREIGN KEY REFERENCES Cities(Id),
IsDeleted BIT DEFAULT 0 );

– 1) Employees + City + Country SELECT e.Name, e.Surname, c.Name AS
City, co.Name AS Country FROM Employees e JOIN Cities c ON e.CityId =
c.Id JOIN Countries co ON c.CountryId = co.Id;

– 2) Salary > 2000 employees + countries SELECT e.Name, e.Surname,
co.Name AS Country FROM Employees e JOIN Cities c ON e.CityId = c.Id
JOIN Countries co ON c.CountryId = co.Id WHERE e.Salary > 2000;

– 3) Cities + Countries SELECT c.Name AS City, co.Name AS Country FROM
Cities c JOIN Countries co ON c.CountryId = co.Id;

– 4) Reseption workers (without Id) SELECT Name, Surname, Age, Salary,
Position, IsDeleted, CityId FROM Employees WHERE Position = ‘Reseption’;

– 5) Fired employees’ city & country SELECT e.Name, e.Surname, c.Name AS
City, co.Name AS Country FROM Employees e JOIN Cities c ON e.CityId =
c.Id JOIN Countries co ON c.CountryId = co.Id WHERE e.IsDeleted = 1;
