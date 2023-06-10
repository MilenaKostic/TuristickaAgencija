CREATE PROCEDURE AnalizaNajposecenijegPutovanja
AS
BEGIN
    SELECT TOP 1
        p.NazPuta,
        COUNT(r.IdPuta) AS BrojRezervacija
    FROM
        PUTOVANJE p
    INNER JOIN
        REZERVISE r ON p.IdPuta = r.IdPuta
    GROUP BY
        p.NazPuta
    ORDER BY
        BrojRezervacija DESC;

END
