use master;

if exists (select * from sysdatabases where name='dbProjetE2')
  DROP database dbProjetE2
GO
CREATE DATABASE dbProjetE2
GO



