CREATE TRIGGER SpreciBrisanjePutovanja
ON PUTOVANJE
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Provera da li putovanje ima rezervacije
    IF EXISTS (
        SELECT 1
        FROM REZERVISE
        WHERE IdPuta IN (SELECT IdPuta FROM deleted)
    )
    BEGIN
        -- Ako postoje rezervacije, prikaži grešku i prekini brisanje putovanja
        RAISERROR ('Brisanje putovanja nije dozvoljeno jer ima povezane rezervacije.', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        -- Ako nema rezervacija, izvrši brisanje putovanja
        DELETE FROM PUTOVANJE
        WHERE IdPuta IN (SELECT IdPuta FROM deleted);
    END
END

