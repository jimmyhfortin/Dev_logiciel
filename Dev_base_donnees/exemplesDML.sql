/*
Clients(#IDClient, Nom, Prénom)
Produits(#CodeProduit, Libellé)
Factures(#NFacture, date)
-> MCD
Clients (0,N) --(acheter)-- (0,N) Produits 
Clients (0,N) --(payer)-- (1,1) Factures 
-> Schéma relationnel
Clients(#IDClient, Nom, Prénom, statut)
Produits(#CodeProduit, Libellé)
Achats((PK)((FK)IDClient, (FK)CodeProduit))
Factures(#NFacture, date, #IDClient)
*/
drop database if exists Boutique;
create database if not exists Boutique;
use Boutique;

drop table if exists Produits;
create table if not exists Produits(
CodeProduit int primary key,
Libellé varchar(50)
);

drop table if exists Clients;
create table if not exists Clients(
IDClient int primary key auto_increment,
Nom varchar(30),
Prénom varchar(30),
statut int
);
describe Clients;
select * from Clients;

drop table if exists Factures;
create table if not exists Factures(
NFacture int primary key,
date date,
IDClient int,
foreign key(IDClient) references Clients(IDClient) 
);
insert into Factures values(100,"2020-04-01",1);
truncate Factures;
select * from Factures;
drop table if exists Achats;
create table if not exists Achats(
IDClient int, 
CodeProduit int,
foreign key(IDClient) references Clients(IDClient),
foreign key(CodeProduit) references Produits(CodeProduit),
primary key(IDClient, CodeProduit)
);
-- -------------
-- insertion de donnees
select * from Clients;
select Nom,Prénom from Clients;
-- exemples d'insertions
insert into Clients(IDClient,Nom,Prénom,statut) values(1,"Errahmouni","Hind",1);
insert into Clients values(2,"Tremblay","Karl",0);
insert into Clients(Nom,Prénom,statut) values("Godin","Gérald",1);
insert into Clients(Nom,Prénom,statut) values("Gosselin","Nancy",0),("Tijani","Ahmed",0),("Roy","Mélanie",1);
create table if not exists ClientsNonActifs(
IDClient int primary key auto_increment,
Nom varchar(30),
Prénom varchar(30)
);
insert into ClientsNonActifs(Nom, Prénom) select Nom,Prénom from Clients Where statut = 0;
select * from ClientsNonActifs;
update Clients set Nom = NULL where IDclient and statut = 1;
delete from Clients where IDClient ;
truncate Clients;






-- exemple DML2
/*
Clients(#IDClient, Nom, Prénom)
Produits(#CodeProduit, Libellé)
Factures(#NFacture, date)
-> MCD
Clients (0,N) --(acheter)-- (0,N) Produits 
Clients (0,N) --(payer)-- (1,1) Factures 
-> Schéma relationnel
Clients(#IDClient, Nom, Prénom, statut)
Produits(#CodeProduit, Libellé)
Achats((PK)((FK)IDClient, (FK)CodeProduit))
Factures(#NFacture, date, #IDClient)
*/
drop database if exists Boutique;
create database if not exists Boutique;
use Boutique;

drop table if exists Produits;
create table if not exists Produits(
CodeProduit int primary key,
Libellé varchar(50)
);

drop table if exists Clients;
create table if not exists Clients(
IDClient int primary key auto_increment,
Nom varchar(30),
Prénom varchar(30),
statut int
);
describe Clients;
select * from Clients;

drop table if exists Factures;
create table if not exists Factures(
NFacture int primary key,
date date,
IDClient int,
foreign key(IDClient) references Clients(IDClient) 
);
insert into Factures values(100,"2020-04-01",1);
truncate Factures;
select * from Factures;
drop table if exists Achats;
create table if not exists Achats(
IDClient int, 
CodeProduit int,
foreign key(IDClient) references Clients(IDClient),
foreign key(CodeProduit) references Produits(CodeProduit),
primary key(IDClient, CodeProduit)
);
alter table Achats add Qte_Achetée int not null;
-- -------------
select * from Clients;
select Nom,Prénom from Clients;
-- JEU DE DONNÉES
-- Table Clients
insert into Clients(IDClient,Nom,Prénom,statut) values(1,"Errahmouni","Hind",1);
insert into Clients values(2,"Tremblay","Karl",0);
insert into Clients(Nom,Prénom,statut) values("Godin","Gérald",1);
insert into Clients(Nom,Prénom,statut) values("Gosselin","Nancy",0),("Tijani","Ahmed",0),("Roy","Mélanie",1);
-- Table Produits
insert into Produits values(10,"Croustilles ondulées nature");
insert into Produits values(20,"Barres de céréales Great Value");
insert into Produits values(30,"Gâteaux Twinkiesᴹᴰ de Hostess");
insert into Produits values(40,"Collation aux pommes non sucrée");
insert into Produits values(50,"Amandes enrobées de chocolat au lait");
insert into Produits values(60,"Chocolat blanc Great Value");
insert into Produits values(70,"Guimauves miniatures");
insert into Produits values(80,"Biscuits soda salés Great Value");
insert into Produits values(90,"Pudding au tapioca");
insert into Produits values(100,"Friandise rondelles aux pêches");
-- Table Achats
insert into Achats values(1,10,2);
insert into Achats values(1,20,3);
insert into Achats values(1,40,1);
insert into Achats values(3,50,5);
insert into Achats values(1,30,2);
insert into Achats values(4,80,10);
insert into Achats values(5,30,2);
insert into Achats values(6,30,1);
insert into Achats values(5,70,1);
insert into Achats values(6,60,2);
-- 10:  1 20: 1 30: 3 40:1 50:1 60:1 70:1 80:1 90:0
select * from Achats;
/*create table if not exists ClientsNonActifs(
IDClient int primary key auto_increment,
Nom varchar(30),
Prénom varchar(30)
);
insert into ClientsNonActifs(Nom, Prénom) select Nom,Prénom from Clients Where statut = 0;
select * from ClientsNonActifs;
update Clients set Nom = NULL where IDclient and statut = 1;
delete from Clients where IDClient ;
truncate Clients;*/
-- exercice select
-- 1: selectionner les noms et prénoms des clients qui sont actifs
-- 2: combien de client on a dans la bdd ?
-- 3: quels sont les clients qui ont un nom commencent par T?
-- 4: récupérer les noms des produits déjà achetés?
-- 5: combien de produit le client numéro 1 a acheté?
-- 6: récupérer le produit qui est déjà acheté par tous les clients qui ont déjà passé des commandes.
-- 7: combien de clients qui n'ont jamais acheté de produit?
-- 8: quels sont les produits qui ne sont jamais achetés?
-- 9: retourner le nombre des produits achetés par client.
-- 10: le client 3 a t'il déjà acheté le produit numéro 80?
-- réponses:
-- 1: selectionner les noms et prénoms des clients qui sont actifs
select Nom, Prenom from Clients where statut = 1;
-- 2: combien de client on a dans la bdd ?
select count(*) AS 'nombre des clients' from Clients;
-- 3: quels sont les clients qui ont un nom commencent par T?
select Nom AS 'Noms Clients commencent par T' from Clients where Nom LIKE 'T%';
-- 4: récupérer les noms des produits déjà achetés?
select distinct Achats.CodeProduit,Libellé AS 'Produits achetés' from Produits, Achats where Achats.CodeProduit = Produits.CodeProduit;
-- 5: combien de produit le client numéro 1 a acheté?
select count(CodeProduit) AS 'nombre produits'from Achats where IDClient = 1;
-- 6: récupérer le produit qui est déjà acheté par tous les clients qui ont déjà passé des commandes.
select CodeProduit from Achats group by CodeProduit order by count(IDClient) DESC limit 1;
-- 7: combien de clients qui n'ont jamais acheté de produit?
select distinct Clients.IDClient from Clients where Clients.IDClient NOT IN(select IDClient from Achats); 
-- 8: quels sont les produits qui ne sont jamais achetés?
select distinct Produits.CodeProduit from Produits where Produits.CodeProduit NOT IN(select CodeProduit from Achats);
-- 10: le client 3 a t'il déjà acheté le produit numéro 80?
SELECT distinct
    CASE IDClient
        WHEN
            3
        THEN
            CASE
                WHEN CodeProduit = 80 THEN 'Oui'
                ELSE 'NON'
            END 
    END 'le client 3 a déjà acheté le produit 80??'
FROM
    Achats;
    

-- ------------------------------------------------
-- requetes avancer 