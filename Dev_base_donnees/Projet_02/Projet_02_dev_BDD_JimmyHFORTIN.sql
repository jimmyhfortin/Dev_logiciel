										
                                        /**//**/-- Étape 2: Définition des données (DDL) -- /**//**/
                                            
-- création de la base de donnée
create database Jeux_de_donnees;
-- utilisation de la base donnée Jeux_de_donnees
use Jeux_de_donnees;
drop database Jeux_de_donnees;
-- drop table;


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
typeTIRAGE int, -- (inclusif=1 & exculif=0)
-- clef étrangère
foreign key(idLISTE) references Liste(idLISTE)
);

create table Element_Tirage(
-- clef primaire
Position int,
-- clefs primaire composites
idELEMENT int,
idTIRAGE int,
-- Définition des clefs primarire composites
foreign key(idELEMENT) references Element(idELEMENT),
foreign key(idTIRAGE) references Tirage(idTIRAGE),
primary key(Position,idELEMENT,idTIRAGE)
);


										/**//**/-- Étape 3: Manipulation des données (DML) --/**//**/

-- ajout de donnée à la table (Liste)
insert into Liste(idLISTE,nomLISTE) value(01,"Tirage_Lundi");
insert into Liste value(02,"Tirage_Mardi"), (03,"Tirage_Mercredi"), (04,"Tirage_Jeudi"), (05,"Tirage_Fin_de_Semaine");
select * from Liste;
--

-- ajout de donnée à la table (Element)
insert into Element(idELEMENT, idLISTE, nomELEMENT) value(101,01,"Voiture");
insert into Element value(102,02,"Bateaux"), (103,02,"Maison"), (104,01,"Voyage"), (105,02,"Tout-Terrain");
insert into Element value(106,06,"Escapade_Tropicale");
select * from Element;
--

-- ajout de donnée à la table (Tirage)
insert into Tirage(idTIRAGE, idLISTE, nomTIRAGE, descriptionTIRAGE, dateCreationTIRAGE, dateEffectueeTIRAGE,nombreElementsAtirerTIRAGE,typeTIRAGE) value(201,01,"Premier_Tirage", "Tirage_premiere_chance","2022-08-13","2021-08-13",1,0);
insert into Tirage value(202,02,"Deuxieme_Tirage", "Tirage_deuxieme_chance","2022-07-10","2022-08-16",1,1), (203,02,"Troisieme_Tirage", "Tirage_troisieme_chance","2022-02-09","2022-06-22",1,1), (204,03,"Quatrieme_Tirage", "Tirage_quatrieme_chance","2022-03-10","2022-05-05",1,0),(205,04,"Cinquieme_Tirage", "Tirage_cinquieme_chance","2022-04-13","2022-04-26",1,0);
insert into Tirage value(206,02,"Derniere_chance", "Derniere_chance","2022-05-10","2022-08-14",4,1);
select * from Tirage;
--

-- ajout de donnée à la table (Element_Tirage)
insert into Element_Tirage(idELEMENT, idTIRAGE, Position) value(101,201,1), (105,203,2), (104,204,3), (103,202,4),(101,205,5), (102,201,6), (105,205,7);
insert into Element_Tirage(idELEMENT, idTIRAGE, Position) value(105,206,8);
select * from Element_Tirage;
--



										/**//**/-- Étape 4: Requêtage des données (DQL) --/**//**/
select * from Element_Tirage;

-- Requête #1
select idTIRAGE,idELEMENT,idListe from Element_Tirage,Liste order by idTIRAGE; -- OK -- une liste des elements comme la tble liste
-- select idTIRAGE,idELEMENT from Element_Tirage inner join Liste order by idTIRAGE;
-- Requête #2
select Liste.idLISTE,count(idELEMENT),count(idTIRAGE) from Liste,Element_Tirage natural join Tirage group by Liste.idLISTE order by idLISTE; -- OK
-- select Liste.idLISTE,count(idELEMENT),count(idTIRAGE) from Liste,Element_Tirage natural join Liste group by Liste.idLISTE order by idLISTE;
-- Requête #3
select nomELEMENT,idLISTE from Element where idLISTE = 2; -- GOOD -- ajouter les type
-- Requête #4
-- select distinct Tirage.idLISTE from Tirage where Tirage.idLISTE NOT IN(select idTIRAGE from Element_Tirage);
select distinct Liste.idLISTE from Liste where Liste.idLISTE NOT IN(select idLISTE from Tirage); -- GOOD
-- Requête #5
select distinct typeTIRAGE,idELEMENT from Tirage,Element where typeTIRAGE = 1; -- marche pas
select distinct idELEMENT,nomELEMENT from Element inner join Tirage on typeTIRAGE = 1; -- a revoir
select Liste.idLISTE,nomLISTE,idTIRAGE from Liste inner join Tirage on tirage.idTIRAGE = null; -- marche pas
select idELEMENT,nomELEMENT,typeTIRAGE from Element inner join Tirage on typeTIRAGE = 1; -- ok
-- Requête #6
select distinct position,idELEMENT,typeTIRAGE from Element_Tirage inner join Tirage on typeTIRAGE = 1 order by Position; -- ok

-- Requête #7
select Tirage.idLISTE,idELEMENT,dateEffectueeTIRAGE from Element inner join Tirage on dateEffectueeTIRAGE < "2021-08-14";

-- Requête #8
select Element_Tirage.idTIRAGE,Tirage.idLISTE from Element_Tirage,Tirage where typeTIRAGE <= 1;
select Tirage.idLISTE,count(typeTIRAGE) from Tirage where typeTIRAGE <= 1 group by idLISTE; -- a revoir avec quelqu'un
-- Requête #9
select Element_Tirage.idELEMENT,Tirage.idLISTE,idTIRAGE from Element_Tirage natural join Tirage where idELEMENT = null;
select Element_Tirage.idELEMENT,Tirage.idLISTE,idTIRAGE from Element_Tirage natural join Tirage where idELEMENT is null; -- a voir avec le prof
-- Requête #10


-- faire le alter table sur la table tirage-element 


