/*********************************************** Database yaradılması və
istifadəsi ***********************************************/ IF
DB_ID(‘CompanyMM’) IS NULL BEGIN CREATE DATABASE CompanyMM; END GO

USE CompanyMM; GO

/*********************************************** Cədvəllərin yaradılması
***********************************************/ IF
OBJECT_ID(‘dbo.Employees’, ‘U’) IS NOT NULL DROP TABLE
dbo.EmployeeProjects; IF OBJECT_ID(‘dbo.Employees’, ‘U’) IS NOT NULL
DROP TABLE dbo.Employees; IF OBJECT_ID(‘dbo.Projects’, ‘U’) IS NOT NULL
DROP TABLE dbo.Projects; GO

CREATE TABLE dbo.Employees ( EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
FirstName NVARCHAR(100) NOT NULL, LastName NVARCHAR(100) NOT NULL,
BirthDate DATE NOT NULL, Email NVARCHAR(255) NOT NULL UNIQUE, CONSTRAINT
CHK_Employees_BirthDate CHECK (BirthDate <= CAST(GETDATE() AS DATE)) );
GO

CREATE TABLE dbo.Projects ( ProjectID INT IDENTITY(1,1) PRIMARY KEY,
ProjectName NVARCHAR(200) NOT NULL, StartDate DATE NOT NULL, EndDate
DATE NOT NULL, CONSTRAINT CHK_Projects_Dates CHECK (EndDate >=
StartDate) ); GO

CREATE TABLE dbo.EmployeeProjects ( EmployeeID INT NOT NULL, ProjectID
INT NOT NULL, AssignedDate DATE NOT NULL DEFAULT CAST(GETDATE() AS
DATE), CONSTRAINT PK_EmployeeProjects PRIMARY KEY (EmployeeID,
ProjectID), CONSTRAINT FK_EmpProj_Employee FOREIGN KEY (EmployeeID)
REFERENCES dbo.Employees(EmployeeID) ON DELETE CASCADE, CONSTRAINT
FK_EmpProj_Project FOREIGN KEY (ProjectID) REFERENCES
dbo.Projects(ProjectID) ON DELETE CASCADE, CONSTRAINT
CHK_EmpProj_AssignedDate CHECK (AssignedDate >= ‘1900-01-01’) ); GO

/*********************************************** Nümunə data
***********************************************/ INSERT INTO
dbo.Employees (FirstName, LastName, BirthDate, Email) VALUES (‘Murad’,
‘Hüseynov’, ‘1990-05-10’, ‘murad.huseynov@example.com’), (‘Aylin’,
‘Məmmədova’, ‘1988-11-22’, ‘aylin.mammadova@example.com’), (‘Elvin’,
‘Quliyev’, ‘1995-02-03’, ‘elvin.guliyev@example.com’), (‘Leyla’,
‘Əhmədova’, ‘1992-07-19’, ‘leyla.ahmedova@example.com’), (‘Rəşad’,
‘İsmayılov’, ‘1985-03-30’, ‘rashad.ismayilov@example.com’); GO

INSERT INTO dbo.Projects (ProjectName, StartDate, EndDate) VALUES (‘Veb
Platforma Yenilənməsi’, ‘2025-01-15’, ‘2025-06-30’), (‘Mobil App
İnkişafı’, ‘2025-03-01’, ‘2025-12-31’), (‘Məlumat Analitikası’,
‘2025-02-01’, ‘2025-08-31’); GO

INSERT INTO dbo.EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
VALUES (3, 1, ‘2025-01-20’), (3, 2, ‘2025-03-10’), (3, 3, ‘2025-02-15’);

INSERT INTO dbo.EmployeeProjects (EmployeeID, ProjectID) VALUES (1, 1),
(1, 2), (2, 3), (4, 1); GO

/*********************************************** View
***********************************************/ IF
OBJECT_ID(‘dbo.EmployeeProjectView’,‘V’) IS NOT NULL DROP VIEW
dbo.EmployeeProjectView; GO

CREATE VIEW dbo.EmployeeProjectView AS SELECT e.EmployeeID,
(e.FirstName + N’ ’ + e.LastName) AS FullName, p.ProjectID,
p.ProjectName, ep.AssignedDate FROM dbo.EmployeeProjects ep JOIN
dbo.Employees e ON ep.EmployeeID = e.EmployeeID JOIN dbo.Projects p ON
ep.ProjectID = p.ProjectID; GO

/*********************************************** Stored Procedure
***********************************************/ IF
OBJECT_ID(‘dbo.sp_AssignEmployeeToProject’, ‘P’) IS NOT NULL DROP
PROCEDURE dbo.sp_AssignEmployeeToProject; GO

CREATE PROCEDURE dbo.sp_AssignEmployeeToProject @empId INT, @projId INT
AS BEGIN SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 1 FROM dbo.Employees WHERE EmployeeID = @empId)
    BEGIN
        RAISERROR('Employee tapilmadi.', 16, 1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM dbo.Projects WHERE ProjectID = @projId)
    BEGIN
        RAISERROR('Project tapilmadi.', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM dbo.EmployeeProjects WHERE EmployeeID = @empId AND ProjectID = @projId)
    BEGIN
        RETURN;
    END

    INSERT INTO dbo.EmployeeProjects (EmployeeID, ProjectID, AssignedDate)
    VALUES (@empId, @projId, CAST(GETDATE() AS DATE));

END; GO

/*********************************************** Function
***********************************************/ IF
OBJECT_ID(‘dbo.fn_GetProjectCount’, ‘FN’) IS NOT NULL DROP FUNCTION
dbo.fn_GetProjectCount; GO

CREATE FUNCTION dbo.fn_GetProjectCount (@empId INT) RETURNS INT AS BEGIN
DECLARE @cnt INT; SELECT @cnt = COUNT(*) FROM dbo.EmployeeProjects WHERE
EmployeeID = @empId; RETURN ISNULL(@cnt, 0); END; GO

SELECT dbo.fn_GetProjectCount(3) AS ProjectCount_For_Employee3; GO

/*********************************************** Silmə
***********************************************/ DELETE FROM
dbo.EmployeeProjects WHERE EmployeeID = 4; GO
