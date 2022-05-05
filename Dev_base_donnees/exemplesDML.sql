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
