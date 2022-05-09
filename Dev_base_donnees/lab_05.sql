create database hotel;
use hotel;

create table Chambre(
Num_Chambre int primary key,
Prix int not null,
Nbr_Lit int,
Nbr_pers int,
Confort varchar(30),
Equ varchar(30)
);

create table Clients(
Num_Client int primary key auto_increment,
Nom varchar(20) not null,
Prenom varchar(20) not null,
Adresse varchar(50) not null
);

create table Reservation(
Num_Client int,
Num_Chambre int,
Date_Arr date not null,
Date_Dep date,
foreign key(Num_Client) references Clients(Num_Client),
foreign key(Num_Chambre) references Chambre(Num_Chambre)
);

select * from Chambre;
select * from Clients;
insert into Chambre(Num_Chambre,Prix,Nbr_Lit,Nbr_Pers,Confort,Equ) values(10,80,01,02,"WC","Non");
insert into Chambre(Num_Chambre,Prix,Nbr_Lit,Nbr_Pers,Confort,Equ) values(20,100,02,02,"Douche","Non");
insert into Chambre(Num_Chambre,Prix,Nbr_Lit,Nbr_Pers,Confort,Equ) values(25,180,03,03,"Bain","TV");

insert into Clients(Num_Client,Nom,Prenom,Adresse) values(1000,"Denez","Desmond","Marseille");
insert into Clients(Nom,Prenom,Adresse) values("Paul","Desmarais","Tokyo");
insert into Clients(Nom,Prenom,Adresse) values("Denez","Desmond","Marseille");
