use dbProjetE2Test;
GO


IF OBJECT_ID('Jeux.trigInstblJeuTag', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblJeuTag;
END

IF OBJECT_ID('Jeux.trigInstblPlateformeTag', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblPlateformeTag;
END

GO
CREATE TRIGGER Jeux.trigInstblJeuTag	ON Jeux.tblJeu
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdJeu AS INT,
 @IdJeuText AS VARCHAR(250),
 @NomJeu AS  VARCHAR(50),
 @DescJeu AS VARCHAR(250), 
 @CoteESRB AS VARCHAR(3),
 @IdGenre AS INT,
 @IdMode AS INT, 
 @NomGenre AS VARCHAR(35), 
 @NomMode AS VARCHAR(20)
 
SELECT @IdJeu = IdJeu, @NomJeu = NomJeu, @DescJeu = DescJeu, @CoteESRB = CoteESRB, @IdGenre = IdGenre, @IdMode = IdMode
FROM inserted

SET @IdJeuText = CONVERT(VARCHAR(250), @IdJeu)

SELECT @NomGenre = NomGenre
FROM Jeux.tblGenre
WHERE IdGenre = @IdGenre

SELECT @NomMode = NomMode
FROM Jeux.tblMode
WHERE IdMode = @IdMode

UPDATE Jeux.tblJeu
SET Tag = @IdJeuText + ' ' +@NomJeu + ' ' + @DescJeu + ' ' + @CoteESRB + ' ' + @NomGenre + ' ' + @NomMode
WHERE IdJeu = @IdJeu

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblJeuTag réussie'
    
    
GO
CREATE TRIGGER Jeux.trigInstblPlateformeTag	ON Jeux.tblPlateforme
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdPlateforme AS INT,
 @IdPlateformeText AS VARCHAR(250),
 @CodePlateforme AS  VARCHAR(10),
 @NomPlateforme AS VARCHAR(40),
 @CPU AS VARCHAR(40),
 @CarteMere AS VARCHAR(60),
 @RAM AS VARCHAR(60),
 @Stockage AS VARCHAR(60),
 @DescPlateforme AS VARCHAR(250),
 @CodeCategorie AS VARCHAR(7),
 @DescCategorie AS VARCHAR(40)

 
SELECT @IdPlateforme = IdPlateforme, @CodePlateforme = CodePlateforme, @NomPlateforme = NomPlateforme,@CPU = CPU, 
@CarteMere = CarteMere, @RAM = RAM, @Stockage = Stockage, @DescPlateforme = DescPlateforme, @CodeCategorie = CodeCategorie
FROM inserted

SET @IdPlateformeText = CONVERT(VARCHAR(250), @IdPlateforme)

SELECT @DescCategorie = DescCategorie
FROM Jeux.tblCategorie
WHERE CodeCategorie = @CodeCategorie


UPDATE Jeux.tblPlateforme
SET Tag = @IdPlateformeText + ' ' +@CodePlateforme + ' ' + @NomPlateforme + ' ' + @CPU + ' ' +
 @CarteMere + ' ' + @RAM+ ' ' + @Stockage + ' ' + @DescPlateforme + ' ' + @CodeCategorie + ' ' + @DescCategorie
WHERE IdPlateforme = @IdPlateforme

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblPlateformeTag réussie'    

