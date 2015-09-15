use dbProjetE2Test;

GO
CREATE TRIGGER Jeux.trigInstblJeuTag	ON Jeux.tblJeu
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdJeu AS INT,
 @NomJeu AS  VARCHAR(50),
 @DescJeu AS VARCHAR(250), 
 @CoteESRB AS VARCHAR(3), 
 @NomGenre AS VARCHAR(35), 
 @NomMode AS VARCHAR(20)
 
SELECT @IdJeu = IdJeu, @NomJeu = NomJeu, @DescJeu = DescJeu, @CoteESRB = CoteESRB 
FROM inserted

UPDATE Jeux.tblJeu
SET Tag = @NomJeu + ' ' + @DescJeu + ' ' + @CoteESRB
WHERE IdJeu = @IdJeu

END;
GO   
    
    
--GO
--create trigger TotHeureApp on Vol.tblVolEffectif
--after insert
--as
--begin
--declare @NoVol as char(5), @NoImmatriculation as char(7), @nbHeure as tinyint
--select @NoVol=noVol, @NoImmatriculation=noImmatriculation
--from inserted

--select @nbHeure = dureeTotalePrevue
--from Vol.tblVolGenerique
--WHERE noVol = @NoVol

--UPDATE Appareil.tblAppareil 
--SET nbHeuresVol = nbHeuresVol + @nbHeure
--WHERE noImmatriculation = @NoImmatriculation
--end;
--GO