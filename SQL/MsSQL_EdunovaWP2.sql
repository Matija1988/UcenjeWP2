use master;
go
drop database if exists edunovawp2;
go
create database edunovawp2; 
go
alter database edunovawp2 collate Croatian_CI_AS;
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
--komentirao -- dodavanje vanjskih ključeva i povezivanje tablica 
alter table grupe add foreign key (smjerSifra) references smjerovi(sifra); 
alter table grupe add foreign key (predavacSifra) references predavaci(sifra); 
alter table clanovi add foreign key (grupa) references grupe(sifra);
alter table clanovi add foreign key (polaznik) references polaznici(sifra);

-- OVA NAREDBA UNOSI JEDAN RED U TABLICU
insert into smjerovi (naziv, brojSati, cijena, upisnina, verificiran)
values ('Web programiranje', 225, 1325.85, null, 1);


-- minimalni unos
-- primjer unosa dva reda
insert into smjerovi (naziv) values 
('Java programiranje'),
('Seviser');

insert into predavaci (ime, prezime, email) values
-- 1
('Tomislav', 'Jakopec', 'tjakopec@gmail.com'),
-- 2
('Shaquille','O''Neal','shaki@gmail.com');

insert into polaznici (ime, prezime, email) values
('Matija','Pavković','matijapavkovic74@gmail,com'),
('Natalija','Glavaš','natalija-glavas@hotmail.com');

insert into grupe (naziv, smjerSifra, datumPocetka) values
('WP1', 1, '2023-04-24 17:00:00'),
('WP2', 1, '2023-10-30 17:00:00'),
('JP28', 2, '2023-04-24 19:00:00');

insert into clanovi (grupa, polaznik) values
(2,1),
(2,2);

