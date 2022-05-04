-- MLD01-------------------------------------------------------------------------------
Create database MLD01;
use MLD01;
create table Entreprise(
Id_ent int primary key,
Raison_sociale varchar(20) not null
);

create table Ent_adr(
Id_ent int,
Id_type int,
Id_Adresse int,
foreign key(Id_ent) references Entreprise(Id_ent),
foreign key(Id_type) references Type_Adresse(Id_type),
foreign key(Id_Adresse) references Adresse(Id_Adresse),
primary key(Id_ent, Id_type, Id_Adresse) 
);

create table Type_Adresse(
Id_type int primary key,
Libelle varchar(30)
);

create table Adresse(
Id_Adresse int primary key,
Cp varchar(10),
Ville varchar(30)
);

create table Ind_Adr(
Id_ind int,
Id_type int not null,
Id_Adresse int,
foreign key(Id_ind) references Interlocuteur(Id_ind),
foreign key(Id_type) references Type_Adresse(Id_type),
foreign key(Id_Adresse) references Adresse(Id_Adresse),
primary key(Id_ind, Id_type, Id_Adresse) 
);

create table Interlocuteur(
Id_ind int primary key,
Nom varchar(10),
Prenom varchar(30)
);
-- MLD02------------------------------------------------------------------
create database MLD02;
use MLD02;
create table Formule(
fID int primary key,
fNom varchar(20) not null
);

create table Param(
pID int primary key,
pNom varchar(20) not null
);

create table Posseder(
pID int not null,
fID int not null,
foreign key(pID) references Param(pID),
foreign key(fID) references Formule(fID),
primary key(pID, fID) 
);

create table Renseigner(
cID int not null,
pID int not null, -- utilile ou necessaire(not null vs foreign key)?
fID int not null,
valeur varchar(10),
foreign key(cID) references Classe(cID),
foreign key(pID) references Posseder(pID),
foreign key(fID) references Formule(fID),
primary key(cID, pID) -- clef composite et aussi primary key(comparaison a la table type_adresse juste composite et celle-ci primary key)?
);

create table Classe(
cID int primary key,
cNom varchar(30)
);
-- MLD03----------------------------------------------------------------------
create database MLD03;
use MLD03;
-- impossible sans le MLD ! 
