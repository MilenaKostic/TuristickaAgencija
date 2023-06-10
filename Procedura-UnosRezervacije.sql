CREATE PROCEDURE RezervisiPutovanje
    @IdK INT,
    @IdPuta INT,
	@IdPrzs INT,
	@IdAg INT
AS
BEGIN
    -- Provera da li putovanje i klijent postoje
    IF EXISTS (SELECT 1 FROM PUTOVANJE WHERE IdPuta = @IdPuta) AND EXISTS (SELECT 1 FROM KLIJENT WHERE IdK = @IdK)
    BEGIN
        -- Ubacivanje rezervacije u tabelu rezervacija
        INSERT INTO REZERVISE(IdK, IdPuta, IdPrzs, IdAg)
        VALUES (@IdK, @IdPuta, @IdPrzs, @IdAg)

        PRINT 'Rezervacija uspešno izvršena.'
    END
    ELSE
    BEGIN
        PRINT 'Nevažeći ID putovanja ili klijenta.'
    END
END


