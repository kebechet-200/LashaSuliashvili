CREATE FUNCTION dbo.FindSegment(@deposit MONEY)
RETURNS VARCHAR(20) AS BEGIN
DECLARE @Amount MONEY
DECLARE @Segment VARCHAR(20)
SET @Amount = @deposit
IF @Amount < 10000 SET @Segment = 'Low'
IF @Amount < 50000 AND @Amount > 10000 SET @Segment = 'Medium'
IF @Amount > 50000 SET @Segment = 'High'
RETURN @Segment
END