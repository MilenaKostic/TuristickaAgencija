CREATE FUNCTION BrojRezervacijaZaPutovanje
    (@PutovanjeID INT)
RETURNS INT
AS
BEGIN
    DECLARE @BrojRezervacija INT;
    
    SELECT @BrojRezervacija = COUNT(*) 
    FROM REZERVISE
    WHERE IdPuta = @PutovanjeID;
    
    RETURN @BrojRezervacija;
END

