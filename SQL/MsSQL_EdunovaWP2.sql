use master;
go
drop database if exists edunovawp2;
go
create database edunovawp2; 
go
use edunovawp2;

create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
brojSati int,
cijena decimal(18,2),
upisnina decimal(18,2),
verificiran bit 
);

create table grupe (
sifra int not null primary key identity(1,1), 
naziv varchar(50) not null,
predavacSifra int,
smjerSifra int not null,
maksPolaznika int, 
datumPocetka datetime
);

create table predavaci(
sifra int not null primary key identity(1,1), 
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11), 
email varchar(100) not null, 
iban varchar(50)
);

create table polaznici (
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
oib char(11),
email varchar(100) not null,
brojUgovora varchar(20)
);

create table clanovi(
grupa int not null,
polaznik int not null
);
--komentirao
alter table grupe add foreign key (smjerSifra) references smjerovi(sifra); 

alter table grupe add foreign key (predavacSifra) references predavaci(sifra); 

alter table clanovi add foreign key (grupa) references grupe(sifra);

alter table clanovi add foreign key (polaznik) references polaznici(sifra);

