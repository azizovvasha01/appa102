-- DATABASE yaratmaq
CREATE DATABASE Company;
USE Company;

-- Employees cədvəli
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100),
    PhoneNumber VARCHAR(20),
    HireDate DATE,
    JobTitle VARCHAR(50),
    Salary DECIMAL(10,2),
    Department VARCHAR(50)
);

-- 5 işçi əlavə etmək
INSERT INTO Employees VALUES
(1, 'Leyla', 'Həsənova', 'leyla@company.az', '0501112233', '2021-03-01', 'HR Specialist', 2500, 'HR'),
(2, 'Murad', 'Əliyev', 'murad@company.az', '0512223344', '2019-05-12', 'Developer', 3000, 'IT'),
(3, 'Aysel', 'Quliyeva', 'aysel@company.az', '0705556677', '2022-01-10', 'Designer', 1800, 'Marketing'),
(4, 'Kamran', 'Rzayev', 'kamran@company.az', '0559991122', '2020-11-20', 'System Admin', 3200, 'IT'),
(5, 'Nigar', 'Orucova', 'nigar@company.az', '0708889900', '2018-02-14', 'Accountant', 1700, 'Finance');

-- SELECT QUERY-LƏR
SELECT * FROM Employees;
SELECT * FROM Employees WHERE Salary > 2000;
SELECT * FROM Employees WHERE Department = 'IT';
SELECT * FROM Employees ORDER BY Salary DESC;
SELECT FirstName, Salary FROM Employees;
SELECT * FROM Employees WHERE HireDate > '2020-01-01';
SELECT * FROM Employees WHERE Email LIKE '%company.az%';

-- AGGREGATE FUNCTIONS
SELECT MAX(Salary) AS HighestSalary FROM Employees;
SELECT MIN(Salary) AS LowestSalary FROM Employees;
SELECT AVG(Salary) AS AverageSalary FROM Employees;
SELECT COUNT(*) AS TotalEmployees FROM Employees;
SELECT SUM(Salary) AS TotalSalary FROM Employees;

-- GROUP BY
SELECT Department, COUNT(*) AS WorkerCount FROM Employees GROUP BY Department;
SELECT Department, AVG(Salary) AS AvgSalary FROM Employees GROUP BY Department;
SELECT Department, MAX(Salary) AS MaxSalary FROM Employees GROUP BY Department;

-- UPDATE QUERY-LƏR
UPDATE Employees SET Salary = 2800 WHERE EmployeeID = 1;
UPDATE Employees SET Salary = Salary * 1.10 WHERE Department = 'IT';
UPDATE Employees SET JobTitle = 'HR Meneceri' WHERE FirstName = 'Leyla' AND LastName = 'Həsənova';

-- DELETE QUERY-LƏR
DELETE FROM Employees WHERE EmployeeID = 5;
INSERT INTO Employees VALUES
(6, 'Ramil', 'Sadiqov', 'ramil@company.az', '0774442211', '2023-07-01', 'Assistant', 1200, 'Support');
DELETE FROM Employees WHERE Salary < 1500;

-- ƏLAVƏ
SELECT * FROM Employees WHERE FirstName LIKE '%a%';
SELECT * FROM Employees WHERE Salary BETWEEN 2000 AND 2500;
SELECT * FROM Employees WHERE Department IN ('Finance', 'IT');
