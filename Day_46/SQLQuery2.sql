USE [trainingdb]


-- task 1
SELECT c.CustomerFirstName , c.CustomerLastName 
FROM Customers as c, Deposits as d, loan.Loans as l
WHERE c.CustomerID = d.CustomerID AND c.CustomerID = l.CustomerID
GROUP BY c.CustomerFirstName, c.CustomerLastName

-- task 2
SELECT l.LoanID, l.CustomerID, ISNULL(l.Purpose, 'We Dont Know') FROM loan.Loans as l

-- task 3
SELECT *, SUBSTRING(c.EmailAddress, 1, CHARINDEX('@', c.EmailAddress) - 1) as EmailWithoutDomain,
SUBSTRING(c.Phone, 2, CHARINDEX(')', c.Phone) - 2)
FROM Customers as c

-- task 4
SELECT c.CustomerFirstName FROM Customers as c
WHERE LEN(c.CustomerFirstName) > 7

-- task 5
DECLARE @future DATETIME = DATEADD(DAY,18000, '1976/03/29')
SELECT @future as future, DATENAME(WEEKDAY, @future) as WeekDayTime

-- task 6
SELECT l.CustomerID, DATEDIFF(DAY,l.StartDate, l.EndDate) as loanRange 
FROM loan.Loans as l

-- task 7
SELECT *, DATEDIFF(MONTH, c.BirthDate, GETDATE()) as BirthDateInMonths 
FROM Customers as c

-- task 9 
SELECT COUNT(c.CustomerID) as Customers, c.[State] FROM Customers as c
GROUP BY c.[State]

SELECT COUNT(c.CustomerID) as Customers, c.[State], c.City FROM Customers as c
GROUP BY c.City, c.[State]

-- task 10
SELECT t.CreditAccountID, SUM(t.Amount) as Amount FROM Transactions as t
GROUP BY t.CreditAccountID

-- task 11
SELECT c.CustomerID, SUM(t.Amount) as Amount FROM Customers as c, Transactions as t, Accounts as a
WHERE t.CreditAccountID = a.AccountID AND a.CustomerID = c.CustomerID
GROUP BY c.CustomerID

-- Task 12
SELECT l.Currency, SUM(l.Amount) as Amount FROM loan.Loans as l
GROUP BY l.Currency

SELECT l.Currency, l.FilialID, l.ProductID, SUM(l.Amount) as Amount FROM loan.Loans as l
GROUP BY l.Currency, l.FilialID, l.ProductID

-- Task 13

SELECT c.CustomerID, MIN(l.Amount) as minAmount FROM Customers as c, loan.Loans as l
WHERE c.CustomerID = l.CustomerID
GROUP BY c.CustomerID

SELECT c.CustomerID, MAX(l.Amount) as minAmount FROM Customers as c, loan.Loans as l
WHERE c.CustomerID = l.CustomerID
GROUP BY c.CustomerID

SELECT c.CustomerID, COUNT(l.Amount) as loanAmount FROM Customers as c, loan.Loans as l
WHERE c.CustomerID = l.CustomerID
GROUP BY c.CustomerID
-- Task 14

SELECT c.CustomerID, min(t.TransactionDate) as FirstTransactionDate  FROM Customers as c, Transactions as t, Accounts as a
WHERE a.AccountID = t.DebitAccountID AND a.AccountID = c.CustomerID 
GROUP BY c.CustomerID

-- Task 15
SELECT c.CustomerFirstName, c.CustomerLastName FROM Customers as c, loan.Loans as l
WHERE c.CustomerID = l.CustomerID AND l.Currency = 'USD' AND (l.Amount) > 5000
GROUP BY c.CustomerFirstName, c.CustomerLastName

SELECT c.CustomerFirstName, c.CustomerLastName, c.CustomerAddress FROM Customers as c

-- Task 16
SELECT CustomerAddress, COUNT(*) AS CustomerNumber FROM Customers
GROUP BY CustomerAddress
HAVING COUNT(*) > 1