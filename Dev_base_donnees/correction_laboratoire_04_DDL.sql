-- Implémentation du MLD01  laboratoire 04
create database if not exists BDD_MLD01;
use BDD_MLD01;

create table Entreprise(
	Id_ent int primary key,
    RaisonSociale varchar(50) not null
);

create table Adresse(
	Id_Adresse int primary key,
    CP varchar(6) not null,
    Ville varchar(30) not null
);

create table Type_Adresse(
	Id_type int primary key,
    Libelle varchar(30) not null
);

create table Ent_Adr(
	Id_ent int, 
    foreign key(Id_ent) references Entreprise(Id_ent),
    Id_type int,
    foreign key(Id_type) references Type_Adresse(Id_type),
    Id_Adresse int not null,
    foreign key(Id_Adresse) references Adresse(Id_Adresse),
    primary key(Id_ent, Id_type)
);

create table Interlocuteur(
	Id_Int int primary key,
    Nom varchar(30) not null,
    Prenom varchar(30) not null
);

create table Int_Adr(
	Id_Int int, 
    foreign key(Id_Int) references Interlocuteur(Id_Int),
    Id_type int,
    foreign key(Id_type) references Type_Adresse(Id_type),
    Id_Adresse int not null,
    foreign key(Id_Adresse) references Adresse(Id_Adresse),
    primary key(Id_Int, Id_type)
);

-- consulter les tables créés dans la BDD
show tables;

-- Implémentation du MLD02  laboratoire 04
create database if not exists BDD_MLD02;
use BDD_MLD02;

create table Formule(
	FId int primary key,
    FNom varchar(40) not null
);

create table Param(
	PId int primary key auto_increment,
    PNom varchar(30) not null
);

create table Posseder(
	FId int,
    foreign key(FId) references Formule(FId),
    PId int,
    foreign key(PId) references Param(PId),
    primary key(FId, PId)
);
create table Classe(
	CId int primary key auto_increment,
    CNom varchar(30)
);

create table Renseigner(
	CId int,    
    PId int,
    primary key(CId, PId),
    FId int unique,
    foreign key(PId) references Posseder(PId),
    foreign key(FId) references Posseder(FId),
    foreign key(CId) references Classe(CId),
    Valeur int not null
);
-- Implémentation MCD 03
/* 
Schéma relationnel du MCD (unes des solutions possibles):
1ere solution
Pere(#IDPersonne, Nom, Prenom,Adresse)
Mere(#IDPersonne, Nom, Prenom,Adresse)
Personne(#IDPere,#IDMere(clé primaire composite))
Frere(#IDPersonne,#IDFrere)

2eme solution
Personne(#NoPersonne,Nom, Prenom, Adresse, IDPere(clé etrangere),IDMere(clé etrangere), IDFrere(clé etrangere))
*/
create database if not exists BDD_MCD03;
use BDD_MCD03;

create table Personne(
	NoPersonne int primary key,
    Nom varchar(30) not null,
    Prenom varchar(30) not null,
    IDPere int UNIQUE,
    foreign key(IDPere) references Personne (NoPersonne),
    IDMere int unique,
    foreign key(IDMere) references Personne(NoPersonne),
    IDFrere int,
    foreign key(IDFrere) references Personne(NoPersonne)
);
describe Personne;