create database miniProjetAdoDotNet
go 
use miniProjetAdoDotNet
go

create table Classe(idC int primary key identity(1,1), nomC varchar(50))
insert into Classe values('TDI'),('TRI')

create table Matiere(idM int primary key identity(1,1), nomM varchar(50))
insert into Matiere values('Algo'),('C#')

create table Users(login varchar(50) primary key, password varchar(50))
insert into Users values('log1','pass1'),('log2','pass2')

create table Stagiaire(cinS varchar(50) primary key, nomS varchar(50), prenomS varchar(50), idC int)
alter table stagiaire add imageS varchar(50)
alter table Stagiaire add constraint fkS_C foreign key (idC) references Classe(idC)

insert into Stagiaire values('L123','nom1','prenom1',1,'image1.jpg'),('L1234','nom2','prenom2',1,'image2.jpg')
insert into Stagiaire values('L1235','nom1','prenom1',1,'image3.jpg'),('L12346','nom2','prenom2',1,'image4.jpg')
insert into Stagiaire values('F123','nom1','prenom1',2,'image1.jpg'),('LF1234','nom2','prenom2',2,'image2.jpg')
insert into Stagiaire values('F1235','nom1','prenom1',2,'image3.jpg'),('LF12346','nom2','prenom2',2,'image4.jpg')

create table Professeur(cinP varchar(50) primary key, nomP varchar(50), prenomP varchar(50),imageP varchar(50), idM int)
alter table Professeur add constraint fkP_M foreign key (idM) references Matiere(idM)

insert into Professeur values('LM1232','nom1','prenom1',1,'image1.jpg'),('L1234','nom2','prenom2',1,'image2.jpg')
insert into Professeur values('L1235','nom1','prenom1',1,'image3.jpg'),('L12346','nom2','prenom2',1,'image4.jpg')
insert into Professeur values('F123','nom1','prenom1',2,'image1.jpg'),('LF1234','nom2','prenom2',2,'image2.jpg')
insert into Professeur values('F1235','nom1','prenom1',2,'image3.jpg'),('LF12346','nom2','prenom2',2,'image4.jpg')

create table Seance(idS int primary key identity(1,1), 
				    idC int, idM int, temp varchar(50), dateS date)
alter table Seance add constraint fkSC foreign key (idC) references Classe(idC)
alter table Seance add constraint fkS_M foreign key (idM) references Matiere(idM)

insert into Seance values(1,1,'8:30->10','1/5/2021')
insert into Seance values(1,1,'10->12','1/5/2021')

insert into Seance values(2,2,'12->16','2/5/2021')
insert into Seance values(2,2,'14->18','2/5/2021')

create table Absence(cinS varchar(50), idS int, idC int, idM int,
primary key(cinS,idS,idC,idM))

drop table Absence

alter table Absence add constraint fkA_S foreign key (cinS) references Stagiaire(cinS)
alter table Absence add constraint fk_A_C foreign key (idC) references Classe(idC)
alter table Absence add constraint fk_A_M foreign key (idM) references Matiere(idM)
alter table Absence add constraint fkAS foreign key (idS) references seance(idS)
