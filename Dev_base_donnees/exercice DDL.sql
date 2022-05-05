create database hotel;
use hotel;
create table Ent_adr(
Id_ent int,
Id_type int,
Id_Adresse int,
foreign key(Id_ent) references Entreprise(Id_ent),
foreign key(Id_type) references Type_Adresse(Id_type),
foreign key(Id_Adresse) references Adresse(Id_Adresse),
primary key(Id_ent, Id_type, Id_Adresse) 
);

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