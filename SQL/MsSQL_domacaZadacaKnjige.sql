use master; 
go
drop database domacaZadacaKnjige;
go
create database domacaZadacaKnjige;
go
use domacaZadacaKnjige;

create table knjige(
sifra int not null primary key identity(1,1),
naslov varchar(50) not null,
pisac varchar(50) not null,
vlasnik int, 
clan int, 
datumpos datetime,
datumvrac datetime
);

create table clan(
sifra int not null primary key identity(1,1), 
clbroj int
);

create table vlasnik(
sifra int not null primary key identity(1,1),
knjiga int
);

create table osoba(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
adresa varchar(50),
email varchar(50)
);

alter table knjige add foreign key (vlasnik) references vlasnik(sifra);
alter table knjige add foreign key (clan) references clan(sifra);