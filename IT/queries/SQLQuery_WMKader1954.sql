USE [ITUebung]
GO

-- Wir wollen wissen, wer bei der WM 1954 dabei war.
-- F�r Performance lassen wir nicht die Volltexte der 900+ Spieler auf "1954" untersuchen,
-- sondern reduzieren die Datenmenge zun�chst durch einfache Filter.
SELECT Name, Vorname, Geboren, Gestorben, von, bis, Turniere
FROM tb_Spieler
WHERE (Geboren BETWEEN '01.01.1904' AND '01.01.1938'
AND Turniere LIKE '%1954%')
OR Name = 'Herberger'-- Ausnahme.