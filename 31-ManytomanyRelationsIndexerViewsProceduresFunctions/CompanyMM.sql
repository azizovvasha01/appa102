IF DB_ID('CompanyMM') IS NOT NULL
    DROP DATABASE CompanyMM;
GO

CREATE DATABASE CompanyMM;
GO

USE CompanyMM;
GO

CREATE TABLE Employees (
    EmployeeID INT IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    BirthDate DATE NOT NULL CHECK (BirthDate < '2010-01-01'),
    Email NVARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE Projects (
    ProjectID INT IDENTITY PRIMARY KEY,
    ProjectName NVARCHAR(100) NOT NULL,
    StartDate DATE NOT NULL,
    EndDate DATE NULL CHECK (EndDate >= StartDate)
);

CREATE TABLE EmployeeProjects (
    EmployeeID INT NOT NULL,
    ProjectID INT NOT NULL,
    AssignedDate DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_EmployeeProjects PRIMARY KEY (EmployeeID, ProjectID),
    CONSTRAINT FK_EP_Employee FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID),
    CONSTRAINT FK_EP_Project FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)
);

INSERT INTO Employees (FirstName, LastName, BirthDate, Email)
VALUES
('Said', 'Nuraliyev', '1995-05-21', 'said@example.com'),
('Arif', 'Mammadov', '1990-03-11', 'arif@example.com'),
('Leyla', 'Hasanova', '1998-07-19', 'leyla@example.com'),
('Rashad', 'Aliyev', '1992-11-01', 'rashad@example.com'),
('Aygun', 'Qurbanli', '1999-09-09', 'aygun@example.com');

INSERT INTO Projects (ProjectName, StartDate, EndDate)
VALUES
('CRM System', '2024-01-01', '2024-12-31'),
('E-Commerce App', '2024-02-10', '2024-10-20'),
('Mobile Banking', '2024-03-15', '2025-03-15');

INSERT INTO EmployeeProjects (EmployeeID, ProjectID)
VALUES
(1,1),(1,2),
(2,1),
(3,2),(3,3),
(4,3),
(5,1);

SELECT * FROM Employees;
SELECT * FROM Projects;

SELECT 
    E.EmployeeID,
    E.FirstName,
    E.LastName,
    P.ProjectID,
    P.ProjectName,
    EP.AssignedDate
FROM Employees E
JOIN EmployeeProjects EP ON E.EmployeeID = EP.EmployeeID
JOIN Projects P ON P.ProjectID = EP.ProjectID;

SELECT 
    P.ProjectName,
    COUNT(EP.EmployeeID) AS EmployeeCount
FROM Projects P
LEFT JOIN EmployeeProjects EP ON P.ProjectID = EP.ProjectID
GROUP BY P.ProjectName;

SELECT 
    E.EmployeeID,
    E.FirstName,
    E.LastName,
    COUNT(EP.ProjectID) AS ProjectCount
FROM Employees E
JOIN EmployeeProjects EP ON E.EmployeeID = EP.EmployeeID
GROUP BY E.EmployeeID, E.FirstName, E.LastName
HAVING COUNT(EP.ProjectID) > 2;

CREATE VIEW EmployeeProjectView AS
SELECT 
    E.EmployeeID,
    (E.FirstName + ' ' + E.LastName) AS FullName,
    P.ProjectID,
    P.ProjectName,
    EP.AssignedDate
FROM Employees E
JOIN EmployeeProjects EP ON E.EmployeeID = EP.EmployeeID
JOIN Projects P ON P.ProjectID = EP.ProjectID;
GO

SELECT * FROM EmployeeProjectView WHERE EmployeeID = 1;

IF OBJECT_ID('sp_AssignEmployeeToProject', 'P') IS NOT NULL
    DROP PROCEDURE sp_AssignEmployeeToProject;
GO

CREATE PROCEDURE sp_AssignEmployeeToProject
    @empId INT,
    @projId INT
AS
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM EmployeeProjects 
        WHERE EmployeeID = @empId AND ProjectID = @projId
    )
    BEGIN
        INSERT INTO EmployeeProjects(EmployeeID, ProjectID, AssignedDate)
        VALUES (@empId, @projId, GETDATE());
    END
END;
GO

IF OBJECT_ID('fn_GetProjectCount', 'FN') IS NOT NULL
    DROP FUNCTION fn_GetProjectCount;
GO

CREATE FUNCTION fn_GetProjectCount(@empId INT)
RETURNS INT
AS
BEGIN
    DECLARE @cnt INT;
    SELECT @cnt = COUNT(*) 
    FROM EmployeeProjects 
    WHERE EmployeeID = @empId;
    RETURN @cnt;
END;
GO

SELECT dbo.fn_GetProjectCount(1);

EXEC sp_AssignEmployeeToProject 2, 3;
