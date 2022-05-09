										/**//**/-- Étape 2: Définition des données (DDL) -- /**//**/
                                            
-- création de la base de donnée
create database Jeux_de_donnees;
-- utilisation de la base donnée Jeux_de_donnees
use Jeux_de_donnees;
-- drop database Jeux_de_donnees;


-- création des tables (Element, Liste, Tirage et Element_Tirage)
create table Element(
-- clef primraire
idELEMENT int primary key,
-- attributs
idLISTE int,
nomELEMENT varchar(50),
-- clef étrangère
foreign key(idLISTE) references Liste(idLISTE)
);

create table Liste(
-- clef primaire
idLISTE int primary key,
-- attribut
nomLISTE varchar(50)
);

create table Tirage(
-- clef primarire
idTIRAGE int primary key,
-- attributs
idLISTE int,
nomTIRAGE varchar(100),
descriptionTIRAGE text,
dateCreationTIRAGE datetime,
dateEffectueeTIRAGE datetime,
nombreElementsAtirerTIRAGE int,
typeTIRAGE int,
-- clef étrangère
foreign key(idLISTE) references Liste(idLISTE)
);

create table Element_Tirage(
-- clef primaire
idELEMENT int primary key,
-- attributs
idTIRAGE int,
Position int,
-- clef étrangère
foreign key(idELEMENT) references Element(idELEMENT),
foreign key(idTIRAGE) references Tirage(idTIRAGE)
);


										/**//**/-- Étape 3: Manipulation des données (DML) --/**//**/

-- ajout de donnée table (Liste)(simulation jeu de données)(les commandes aurais pu être sur une seul ligne mais pour plus de lisibilité elles sont sur plusieurs)
insert into Liste(idLISTE,nomLISTE) value(01,"Tirage_Lundi");
insert into Liste(idLISTE,nomLISTE) value(02,"Tirage_Mardi");
insert into Liste(idLISTE,nomLISTE) value(03,"Tirage_Mercredi");
insert into Liste(idLISTE,nomLISTE) value(04,"Tirage_Jeudi");
insert into Liste(idLISTE,nomLISTE) value(12,"Tirage_Fin_de_Semaine");

-- ajout de donnée table (Element)(simulation jeu de données)
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(101,01,"Voiture");
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(102,02,"Bateaux");
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(103,03,"Maison");
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(104,04,"Voyage");
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(122,12,"Tout-Terrain");

-- ajout de donnée table (Element)(simulation jeu de données)
insert into Tirage(idTIRAGE, idLISTE, nomTIRAGE, descriptionTIRAGE, dateCreationTIRAGE, dateEffectueeTIRAGE,nombreElementsAtirerTIRAGE,typeTIRAGE) value(122,12,"Tout-Terrain");

