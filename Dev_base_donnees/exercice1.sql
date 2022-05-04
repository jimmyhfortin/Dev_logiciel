create database Exercice_1;
Use Exercice_1;
create table Personne(
Nopers int auto_increment,
primary key(Nopers)
);
show tables;
describe tables Personne;

create table Societe(
NoSuc int primary key,
NoProp int not null
);

create table PersonneSociete(
Nopers int primary key,
NoSuc int not null,
Actionnaire varchar(30),
foreign key(NoSuc) references Societe(NoSuc)
);

create table Proprietaire(
NoPers int primary key auto_increment,
NoProp int null,
/*foreign key(NoPers) references Personne(NoPers)*/
foreign key(NoProp) references Societe(NoSuc)
);
drop table Proprietaire;

