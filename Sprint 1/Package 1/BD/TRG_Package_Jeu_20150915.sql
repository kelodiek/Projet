---- SQL Server Syntax 
--Trigger on an INSERT, UPDATE, or DELETE statement to a table or view (DML Trigger)

--CREATE TRIGGER [ schema_name . ]trigger_name 
--ON { table | view } 
--[ WITH <dml_trigger_option> [ ,...n ] ]
--{ FOR | AFTER | INSTEAD OF } 
--{ [ INSERT ] [ , ] [ UPDATE ] [ , ] [ DELETE ] } 
--[ WITH APPEND ]
--[ NOT FOR REPLICATION ] 
--AS { sql_statement  [ ; ] [ ,...n ] | EXTERNAL NAME <method specifier [ ; ] > }

--<dml_trigger_option> ::=
--    [ ENCRYPTION ]
--    [ EXECUTE AS Clause ]

--<method_specifier> ::= 
--    assembly_name.class_name.method_name
    
    
use dbProjetE2Test;
GO
CREATE TRIGGER Jeux.trigInstblJeuTag	ON Jeux.tblJeu
AFTER INSERT
AS
BEGIN
DECLARE @

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