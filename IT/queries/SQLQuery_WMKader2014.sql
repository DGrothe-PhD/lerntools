USE [ITUebung]
GO

-- Wir wollen wissen, wer bei der WM 2014 dabei war.
-- Für Performance lassen wir nicht die Volltexte der 900+ Spieler auf "2014" untersuchen,
-- sondern reduzieren die Datenmenge zunächst durch einfache Filter.
SELECT Name, Vorname, Turniere
FROM tb_Spieler
WHERE Gestorben IS NULL
AND bis > 2013
AND Turniere LIKE '%2014%'