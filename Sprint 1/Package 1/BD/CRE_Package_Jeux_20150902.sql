use dbProjetE2Test;

IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Jeux')
BEGIN
	EXEC( 'DROP TABLE Jeux.tblSysExp' );
	EXEC( 'DROP TABLE Jeux.tblCategorie' );

	
	EXEC( 'DROP SCHEMA Jeux' );
END
ELSE
BEGIN
    EXEC( 'CREATE SCHEMA Jeux' );
END



GO
CREATE TABLE Jeux.tblSysExp
(
IdSysExp		INT			NOT NULL	IDENTITY(1,1),
CodeSysExp		VARCHAR(10)	NOT NULL,
NomSysExp		VARCHAR(25)	NOT NULL,
EditionSysExp	VARCHAR(40)	NOT NULL,
VersionSysExp	VARCHAR(40)	NULL,
InfoSupSysExp	TEXT		NULL
)
GO
PRINT 'Création de Jeux.tblSysExp complétée'
GO
CREATE TABLE Jeux.tblCategorie
(
CodeCategorie	VARCHAR(7)		NOT NULL,
DescCategorie	VARCHAR(40)		NOT NULL,
ComCategorie	VARCHAR(150)	NULL
)
GO
PRINT 'Création de Jeux.tblCategorie complétée'
GO

use master;