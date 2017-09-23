use master 
create database GestPatient 
use GestPatient 
create Table Patient (
CodePatient varchar(50) constraint PK_Patient Primary key ,
NomPatient varchar(50),
AdressePatient varchar(50),
DateNaissance Date,
SexePatient varchar(50)
)
GO
create table Medecin (
CodeMedecin varchar(50) Constraint PK_Medecin Primary Key,
NomMedecin varchar(50),
TelMedecin varchar(50),
DateEmbauche Date,
SpecialiteMedecin varchar(50)
)
GO
create table RDV (
NumeroRDV int identity(1,1) constraint PK_RDV Primary key ,
DateRDV date,
HeureRDV varchar(50),
codemedecin varchar(50) constraint FK_Medecin_RDV Foreign key references Medecin(CodeMedecin),
codepatient varchar(50) constraint FK_Patient_RDV Foreign Key References Patient(CodePatient)
)



