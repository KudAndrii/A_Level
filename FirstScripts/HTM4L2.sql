USE AdventureWorks2019
GO

-- Task 1
SELECT * FROM Sales.Customer

GO

-- Task 2
SELECT * FROM Sales.Store
ORDER BY [Name] ASC

GO

-- Task 3
SELECT TOP 10 8 FROM HumanResources.Employee
WHERE BirthDate > '1989-09-28'

GO

-- Task 4
SELECT HE.NationalIDNumber, HE.LoginID, HE.JobTitle FROM HumanResources.Employee AS HE
WHERE HE.LoginID LIKE '%0'
ORDER BY HE.JobTitle DESC

GO

-- Task 5
SELECT * FROM Person.Person
WHERE (ModifiedDate BETWEEN '01-01-2008' AND '31-12-2008') AND MiddleName IS NOT NULL AND Title IS NULL

GO

-- Task 6
SELECT [Name] FROM HumanResources.Department

GO

-- Task 7
SELECT TerritoryID, SUM(CommissionPct) AS ComissionPctSum FROM Sales.SalesPerson
GROUP BY TerritoryID
HAVING SUM(CommissionPct) > 0
GO

-- Task 8
SELECT * FROM HumanResources.Employee
WHERE VacationHours = (SELECT MAX(VacationHours) FROM HumanResources.Employee)

GO

--Task 9
SELECT * FROM HumanResources.Employee
WHERE JobTitle IN ('Sales Representative', 'Network Administrator', 'Network Manager')

GO

-- Task 10
SELECT HE.*, '--' AS Separator, PP.* FROM HumanResources.Employee AS HE
LEFT JOIN Purchasing.PurchaseOrderHeader AS PP
ON HE.BusinessEntityID = PP.EmployeeID