										/**//**/-- Étape 2: Définition des données (DDL) -- /**//**/
                                            
-- création de la base de donnée
create database Jeux_de_donnees;
-- utilisation de la base donnée Jeux_de_donnees
use Jeux_de_donnees;
-- drop database Jeux_de_donnees;
-- drop table Liste;


-- création des tables (Element, Liste, Tirage et Element_Tirage)
create table Element(
-- clef primraire
idELEMENT int primary key auto_increment,
-- attributs
idLISTE int,
nomELEMENT varchar(50),
-- clef étrangère
foreign key(idLISTE) references Liste(idLISTE)
);

create table Liste(
-- clef primaire
idLISTE int primary key auto_increment,
-- attribut
nomLISTE varchar(50)
);

create table Tirage(
-- clef primarire
idTIRAGE int primary key auto_increment,
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
-- clef primaire composite
idELEMENT int,
idTIRAGE int,
-- attributs
Position int,
-- Définition des clefs primarires composites
foreign key(idELEMENT) references Element(idELEMENT),
foreign key(idTIRAGE) references Tirage(idTIRAGE),
primary key(idELEMENT,idTIRAGE)
);


										/**//**/-- Étape 3: Manipulation des données (DML) --/**//**/

-- ajout de donnée table (Liste)(simulation jeu de données)
insert into Liste(idLISTE,nomLISTE) value(01,"Tirage_Lundi");
insert into Liste value(02,"Tirage_Mardi"), (03,"Tirage_Mercredi"), (04,"Tirage_Jeudi"), (05,"Tirage_Fin_de_Semaine");
select * from Liste;
--

-- ajout de donnée table (Element)(simulation jeu de données)
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(101,01,"Voiture");
insert into Element value(102,02,"Bateaux"), (103,02,"Maison"), (104,01,"Voyage"), (105,02,"Tout-Terrain");
select * from Element;
--

-- ajout de donnée table (Tirage)(simulation jeu de données)
insert into Tirage(idTIRAGE, idLISTE, nomTIRAGE, descriptionTIRAGE, dateCreationTIRAGE, dateEffectueeTIRAGE,nombreElementsAtirerTIRAGE,typeTIRAGE) value(201,01,"Premier_Tirage", "Tirage_premiere_chance","2022-08-13","2021-08-13",1,0);
insert into Tirage value(202,02,"Deuxieme_Tirage", "Tirage_deuxieme_chance","2022-07-10","2022-08-16",1,1), (203,02,"Troisieme_Tirage", "Tirage_troisieme_chance","2022-02-09","2022-06-22",1,1), (204,03,"Quatrieme_Tirage", "Tirage_quatrieme_chance","2022-03-10","2022-05-05",1,0),(205,04,"Cinquieme_Tirage", "Tirage_cinquieme_chance","2022-04-13","2022-04-26",1,0);
select * from Tirage;
--

-- ajout de donnée table (Element_Tirage)(simulation jeu de données)
insert into Element_Tirage(idELEMENT, idTIRAGE, Position) value(101,201,1), (105,203,2), (104,204,3), (103,202,4),(101,205,5), (102,201,6), (105,205,7);
select * from Element_Tirage;
