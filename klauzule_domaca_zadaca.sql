use svastara; 

select * from artikli where cijena between 1000 and 1100;

select b.*
from  opcine a inner join mjesta b
on a.sifra = b.opcina
where a.naziv='Čepin';

update mjesta set postanskiBroj = 31431 where  sifra=1945;  

select b.ime, b.prezime
from mjesta a inner join kupci b
on b.mjesto = a.sifra
where a.naziv='Osijek'; 

select top 1* from primke where datum between '2017-01-01' and '2017-12-31';

select c.kratkiNaziv, b.kolicina, b.cijena,
b.kolicina * b.cijena as iznos
from primke a inner join ArtikliNaPrimci b
on a.sifra = b.primka
inner join Artikli c on b.artikl = c.sifra
where a.redniBroj = '14778/2017'
order by 4 desc;


select sum (b.kolicina * b.cijena) as ukupniIznos
from primke a inner join ArtikliNaPrimci b
on a.sifra = b.primka
inner join Artikli c on b.artikl = c.sifra
where a.redniBroj = '14778/2017';

select a.rednibroj, d. naziv, sum(b.kolicina * b.cijena) as ukupniIznos,
avg(b.kolicina * b.cijena) as prosjek,
min(b.kolicina * b.cijena) as minimalno,
max(b.kolicina * b.cijena) as minimalno
from primke a inner join ArtikliNaPrimci b
on a.sifra = b.primka
inner join Artikli c on b.artikl = c.sifra
inner join Dobavljaci d on d.sifra = a.dobavljac
where a.datum between '2017-01-01' and '2017-12-31'
group by a.redniBroj, d.naziv
having sum(b.kolicina * b.cijena) > 7000000
order by 3 desc;

-- domaća zadaća pronaći najproduktivnijeg klijenta iz županije

select a.ime, a.prezime, a.jmbg
from kupci a inner join racuni b on a.sifra = b.kupac;
-- kupce je nemoguće izdvojiti -- no info available
select * from racuni;
select * from kupci; 

select d.naziv, a.naziv, sum(f.kolicina * f.cijena) as ukupniIznos
from dobavljaci a inner join mjesta b on a.mjesto = b.sifra
inner join opcine c on b.opcina = c.sifra
inner join zupanije d on c.zupanija = d.sifra
inner join primke e on a.sifra = e.dobavljac
inner join ArtikliNaPrimci f on f.primka = e.sifra
inner join Artikli g on f.artikl = g.sifra
where d.naziv = 'Osječko-baranjska županija'
group by a.naziv, d.naziv
order by 3 desc;

select * from zupanije;
-- traženje igle u plastu sijena
-- obrisati sve artikle koji nisu nikada nabavljeni
select count(*) from artikli; 
select distinct artikl from ArtikliNaPrimci;

-- podupit

select * from artikli where sifra 
not in (select distinct artikl from ArtikliNaPrimci);

delete from artikli where sifra 
not in (select distinct artikl from ArtikliNaPrimci); 

-- domaća zadaća update i delete pomoću spajanja tablica 

merge dobavljaci as target
using primke as source