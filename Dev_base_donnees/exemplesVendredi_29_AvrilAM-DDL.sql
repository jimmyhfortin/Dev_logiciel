-- création d'un base de données
create database Exemple;
-- accéder à la base de données
use Exemple;
-- lister les table d'un base de données ACCÉDÉE
-- show tables;
-- supprimer la base de données 
-- drop database Exemple;
drop table Employe;
create table Employe(
-- les attributs
IDEmploye int auto_increment,
NomEmploye varchar(30),
PrenomEmploye varchar(30) not null,
DateEmbauche datetime,
-- la clé priamire
primary key(IDEmploye)
);
-- supprimer la table projet
drop table Projet;
-- nouvelle table Projet
create table Projet(
IDProjet int primary key,
IDEmploye int ,
-- les contraintes
foreign key(IDEmploye) references Employe(IDEmploye)
);

describe Projet;
-- description de la structure de la table
describe Employe02;
insert into Employe(IDEmploye, NomEmploye, PrenomEmploye, DateEmbauche) values (1,"Tremblay","Martin","2002/10/01");
insert into Projet(IDProjet,IDEmploye) values(1,1);
truncate Projet;
select * from Projet;
select * from Employe;
-- modifier une table
Alter table Employe rename as Employe02;
ALTER TABLE Employe02 add age tinyint not null;
alter table Employe02 change Nom NomEmploye varchar(30) not null;
alter table Employe02 change NomEmploye NomEmploye varchar(20) null;
alter table Employe02 drop column age;

 
/* 
résumé de commandes : Vendredi 29 Avril AM
*/
-- ********************************************************************************************************************
-- Create database Nom_BDD: créer la bdd
-- Create table Nom_table(Nomcolonne typeColonne contrainte(s) ) : créer la table
-- use nom_BDD : accéder à la base de données pour des enventuels modifications, ajouts ou changements
-- drop database NomBDD: supprimer la BDD
-- drop table Nom_table : supprimer la table
-- describe Nom_table : afficher la structure de la table
-- alter table : modifier une table, soit pour:
-- 1- renommer une table avec : alter table Nom_table rename as New_Nom_Table
-- 2- ajouter une colonne avec : alter table Nom_table add nom_colonne type_colonne [contrainte(s) colonne]
-- 3- renommer ou changer le type ou ajouter une/des contraintes à la colonne : alter table Nom_table change ancien_nom nouvea_nom type_colonne contrainte(s)
-- 4- supprimer une colonne de la table : alter table Nom_table drop column nom_colonne
-- *******************************************************************************************************************
/*les contraintes d'intégrité : contraintes qu'on applique sur les colonnes des tables*/
-- primary key : PK ou clé primaire
-- foreign key : FK ou clé étrangère 
-- default : valeur par défaut
-- auto_increment : incrémenter un attribut par 1
-- references : fait reférence à un attribut d'une autre table
-- null : valeur de la colonne optionnelle
-- not null : valeur de la colonne requise
-- *******************************************************************************************************************
/*à revoir*/
-- truncate Nom_table : supprimer toutes les lignes de la table
-- insert into Nom_table(les noms des colonnes) values(les valeurs des colonnes)
-- select * from nom_table : récupérer toutes les données qu'on a dans la table
-- creat database if not exists NomDeLaDataBase;   



