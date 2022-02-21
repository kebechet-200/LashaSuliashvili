-- 1

SELECT 
COUNT(
CASE 
	WHEN 
	DATEPART(MONTH, c.BirthDate) = 12 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 1 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Capricorn,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 1 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 2 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Aquarius,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 2 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 3 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Pisces,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 3 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 4 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Aries,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 4 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 5 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Taurus,
COUNT(
CASE
	WHEN DATEPART(MONTH, c.BirthDate) = 5 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 6 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Gemini,
COUNT(
CASE
	WHEN DATEPART(MONTH, c.BirthDate) = 6 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 7 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Cancer,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 7 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 8 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1
END) as Leo,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 8 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 9 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Virgo,
COUNT(
CASE
	WHEN DATEPART(MONTH, c.BirthDate) = 9 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 10 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Libra,
COUNT(
CASE
	WHEN DATEPART(MONTH, c.BirthDate) = 10 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 11 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Scorpio,
COUNT(
CASE 
	WHEN DATEPART(MONTH, c.BirthDate) = 11 AND DATEPART(DAY, c.BirthDate) > 21 
	OR 
	DATEPART(MONTH, c.BirthDate) = 12 AND DATEPART(DAY, c.BirthDate) < 21 THEN 1 
END) as Sagittarius
FROM Customers as c

-- 1 b
SELECT 
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 0 THEN 1 END) as Monkey,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 1 THEN 1 END) as Rooster,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 2 THEN 1 END) as Dog,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 3 THEN 1 END) as Pig,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 4 THEN 1 END) as Rat,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 5 THEN 1 END) as Ox,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 6 THEN 1 END) as Tigar,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 7 THEN 1 END) as Rabbit,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 8 THEN 1 END) as Dragon,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 9 THEN 1 END) as Snake,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 10 THEN 1 END) as Horse,
COUNT(CASE WHEN DATEPART(YEAR, c.BirthDate) % 12 = 11 THEN 1 END) as Goat
FROM Customers as c

-- 2
SELECT l.Amount, 
CASE 
	WHEN l.Currency = 'USD' THEN l.Amount * 3.1 
	WHEN l.Currency = 'EUR' THEN l.Amount * 3.6
	ELSE l.Amount * 1
END as AmountInGel
FROM loan.Loans as l
GROUP BY l.Amount, l.Currency

-- 3
DECLARE @first INT = 0 
DECLARE @second INT = 1
DECLARE @sum INT

DECLARE @range INT = 8
DECLARE @i INT = 2

PRINT @first
PRINT @second

WHILE (@i < @range)
BEGIN
	SET @sum = @first + @second
	SET @first = @second
	SET @second = @sum
	PRINT @sum
	SET @i = @i + 1
END

-- 4
DECLARE @number INT = 6
DECLARE @counter INT = 1
DECLARE @it INT = 1
WHILE(@it <= @number)
BEGIN 
	SET @counter = @counter * @it
	SET @it = @it + 1
END
PRINT @counter

-- 5
DECLARE @number1 INT = 66
DECLARE @dividerCount INT = 2
DECLARE @iterator INT = 2
WHILE (@iterator <= @number1 / 2)
BEGIN 
	IF @number1 % @iterator = 0 SET @dividerCount += 1
	SET @iterator += 1
END
PRINT @dividerCount

-- 6
SELECT Amount, dbo.FindSegment(Amount) as Segment FROM Deposits
