-- création de la base de donnée
create database Jeux_de_donnees;
-- utilisation de la base donnée Jeux_de_donnees
use Jeux_de_donnees;

-- création des tables (Element, Liste, Tirage et Element_Tirage).
create table Element(
idELEMENT int auto_increment,
idLIST int,
nomELEMENT varchar(50),
foreign key(idLIST) references Liste(idLIST),
primary key(idELEMENT)
);

create table List(
idLIST int primary key auto_increment,
nomELEMENT varchar(50)
);

create table Tirage(
idTIRAGE int primary key auto_increment,
idLIST int,
nomTIRAGE varchar(100),
descriptionTIRAGE text,
dateCreationTIRAGE datetime,
dateEffectueeTIRAGE datetime,
nombreElementsAtirerTIRAGE int,
typeTIRAGE int,
foreign key(idLIST) references Liste(idLIST)
);

create table Element_Tirage(
idELEMENT int primary key auto_increment,
idTIRAGE int,
Position int,
foreign key(idELEMENT) references Element(idELEMENT),
foreign key(idTIRAGE) references Tirage(idTIRAGE)
);
drop table List;
