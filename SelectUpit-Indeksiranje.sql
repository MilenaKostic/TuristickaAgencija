--EXEC RezervisiPutovanje @IdK=1, @IdPuta=2, @IdPrzs=2, @IdAg=1 ;

--select * from REZERVISE

--EXEC AnalizaNajposecenijegPutovanja

--DECLARE @PutovanjeID INT = 2;
--DECLARE @BrojRezervacija INT;
--SET @BrojRezervacija = dbo.BrojRezervacijaZaPutovanje(@PutovanjeID);
--PRINT 'Broj rezervacija za putovanje ' + CAST(@PutovanjeID AS VARCHAR) + ' je: ' + CAST(@BrojRezervacija AS VARCHAR);

--DELETE from PUTOVANJE 
--where NazPuta='Madjarske banje'

--CREATE INDEX IX_PUT_NAZIV ON dbo.PUTOVANJE(IdPuta);

--select * from PUTOVANJE

--CREATE INDEX IX_KLIJENT_NAZIV ON dbo.KLIJENT(IdK);

--select * from REZERVISE