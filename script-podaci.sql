DELETE FROM NABAVLJA;
DELETE FROM AUTOMOBIL;
DELETE FROM VRSTAAUTOMOBILA;
DELETE FROM AUTOBUS;
DELETE FROM SEDOLAZI;
DELETE FROM REZERVISE; 
DELETE FROM PREVOZNOSREDSTVO;
DELETE FROM SMESTAJ; 
DELETE FROM TIPSMESTAJA; 
DELETE FROM OBUHVATA;
DELETE FROM DESTINACIJA; 
DELETE FROM KLIJENT; 
DELETE FROM NUDI;
DELETE FROM PUTOVANJE;
DELETE FROM VODIC;
DELETE FROM AGENCIJA;


INSERT INTO AGENCIJA(NazAg, AdrAg) VALUES
('Modena Travel', 'Ulica Modene 2'),
('Rapsody Travel', 'Bulevar Oslobodjenja 3');

INSERT INTO VODIC(JmbgVod, ImeVod, PrzVod, BrVod, IdAg) VALUES
(120299187, 'Pavle', 'Preradovic', +3816444, 1),
(120299888, 'Miona', 'Veselinov', +3813444, 2);

INSERT INTO PUTOVANJE(NazPuta, CenaPuta, DatumPol, DatumPov) VALUES
('Madjarske banje',2000,'06/06/2023 06:00:00 ', '06/06/2023 23:00:00 '),
('Rumunija 2023',6000,'06/05/2023 05:00:00 ', '06/06/2023 23:00:00 '),
('Leto za mlade 2023',32000,'5/2/2023 13:00:00 ', '5/14/2023 04:00:00');

INSERT INTO NUDI(IdAg, IdPuta) VALUES
(1, 2),
(2, 1); 

INSERT INTO KLIJENT(JmbgK, ImeK, PrzK, BrK) VALUES
(04089884565, 'Ana', 'Velickovic', +38164889),
(04079634565, 'Luka', 'Matic', +38174189);

INSERT INTO DESTINACIJA (NazDest) VALUES
('Segedin'),
('Temisvar'),
('Bukurest'); 

INSERT INTO OBUHVATA(IdPuta, IdDest) VALUES
(1,1),
(2,2),
(2,3);

INSERT INTO TIPSMESTAJA(NazTipa) VALUES 
('Hotel ***'),
('Hotel ****'),
('Apartman'),
('Hostel'),
('Bungalo'); 

INSERT INTO SMESTAJ(IdDest, NazSm, IdTipa) VALUES 
(1, 'Segedin Hotel', 2),
(1, 'Segedin Hotel 2', 1),
(1, 'Segedin Hotel 3', 1); 

INSERT INTO PREVOZNOSREDSTVO(KategorijaPrzs) VALUES
('Autobus'),
('Automobil'),
('Autobus'),
('Autobus'),
('Autobus'),
('Automobil');

INSERT INTO REZERVISE(IdK, IdPuta, IdPrzs, IdAg) VALUES 
(1, 1, 2, 2),
(2, 1, 1, 1);

INSERT INTO SEDOLAZI(IdDest, IdPrzs) VALUES 
(1, 1),
(2, 2); 

INSERT INTO AUTOBUS(BrMesta, RegBrBus, IdPrzs) VALUES 
(40, 'NS-200-NS', 1),
(20, 'BG-330-AA', 3);

INSERT INTO VRSTAAUTOMOBILA(NazVrste) VALUES
('VW'),
('Peugeot'),
('Audi'),
('Renault');

INSERT INTO AUTOMOBIL(RegBrAuto, IdVrste, IdPrzs) VALUES
('NS-099-AA', 1, 6),
('SM-009-MK', 3, 2);

INSERT INTO NABAVLJA(IdAg, IdPrzs) VALUES 
(1, 1),
(1, 2),
(2, 5); 