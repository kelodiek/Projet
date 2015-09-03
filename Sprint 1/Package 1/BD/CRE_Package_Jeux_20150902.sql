use dbProjetE2;
/* pas sur du use au cas ou la bd changerais de nom  ???  A VÉRIFIER*/

GO
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'Jeux')
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

use master;