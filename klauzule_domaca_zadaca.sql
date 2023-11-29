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


select sum (b.kolicina * b.cijena) as ukupniIznoz
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




