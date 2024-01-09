use master; 
go
drop database if exists zadatak1;
go
create database zadatak1 collate croatian_ci_as; 
go
use zadatak1;

create table zupani(
sifra int not null primary key identity(1,1),
ime varchar(50),
prezime varchar(50)
);

create table zupanije(
sifra int not null primary key identity(1,1),
naziv varchar(50),
zupan int
);

create table opcine(
sifra int not null primary key identity(1,1),
zupanija int,
naziv varchar(50)
);

create table mjesta(
sifra int not null primary key identity(1,1),
opcina int,
naziv varchar(50)
);

alter table zupanije add foreign key (zupan) references zupani(sifra);
alter table opcine add foreign key (zupanija) references zupanije(sifra);
alter table mjesta add foreign key (opcina) references opcine(sifra);

INSERT INTO ZUPANI(IME, PREZIME) VALUES(
'MIKE','TYSON'
),
('EVAN','HOLYFIELD'),
('ALIJA','SIROTANOVIĆ');

insert into zupanije (naziv, zupan) values ('obž', 1), 
('VSŽ', 2), 
('PSŽ', 3);



insert into OPCINE (zupanija, NAZIV) values (
1, 'Darda'), 
(1, 'Draž'),
(1, 'Petlovac'),
(1, 'Antunovac'),
(2, 'Erdut'),
(2, 'Negoslavci');

insert into mjesta(opcina, naziv) values(
1, 'Darda'
),(1, 'Mece'),
(1, 'Švajcarnica'), (5, 'Erdut'),(5, 'Dalj'), (5, 'Aljmaš'),
(2, 'Draž'), (2, 'Batina'), (2, 'Duboševica'),
(2, 'Gajić'), (2,'Podolje'), (3, 'Luč');

select * from mjesta;

update mjesta set naziv = 'Mjesto 1' 
where sifra = 12;
update mjesta set naziv = 'Mjesto 2' 
where sifra = 11;
update mjesta set naziv = 'Mjesto 3' 
where sifra = 10;
update mjesta set naziv = 'Mjesto 4' 
where sifra = 9;
update mjesta set naziv = 'Mjesto 5' 
where sifra = 8;
SELECT * FROM MJESTA;
delete from opcine where sifra = 4; 
SELECT * FROM OPCINE;
delete from opcine where sifra = 6;

