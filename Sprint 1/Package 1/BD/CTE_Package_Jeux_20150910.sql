use dbProjetE2Test;
GO

ALTER TABLE Jeux.tblSysExp
ADD CONSTRAINT PK_tblSysExp_IdSysExp	PRIMARY KEY(IdSysExp)
PRINT 'Création de la contrainte PK_tblSysExp_IdSysExp reussie'
GO

ALTER TABLE Jeux.tblCategorie
ADD CONSTRAINT PK_tblCategorie_CodeCategorie	PRIMARY KEY(CodeCategorie)
PRINT 'Création de la contrainte PK_tblCategorie_CodeCategorie reussie'
GO

ALTER TABLE Jeux.tblTheme
ADD CONSTRAINT PK_tblTheme_IdTheme	PRIMARY KEY(IdTheme)
PRINT 'Création de la contrainte PK_tblTheme_IdTheme reussie'
GO

ALTER TABLE Jeux.tblClassification
ADD CONSTRAINT PK_tblClassification_CoteESRB	PRIMARY KEY(CoteESRB)
PRINT 'Création de la contrainte PK_tblClassification_CoteESRB reussie'
GO

GO
use master;