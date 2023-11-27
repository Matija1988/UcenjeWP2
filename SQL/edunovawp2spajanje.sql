select * from grupe;

--select a.sifra, a.naziv, b.naziv as smjer,
--a.datumpocetka, c.ime, c.prezime,
--CONCAT(e.ime,'', e.prezime) as polaznik
--from grupe a inner join smjerovi b 
--on b.sifra = a.smjerSifra 
--left join predavaci c
--on c.sifra = a.predavacSifra
--inner join clanovi d on a.sifra = d.grupa
--inner join polaznici e on d.polaznik = e.sifra; 


use knjiznica;

select * from katalog;

select a.naslov, b.ime, b.prezime, c.naziv, d.naziv
from katalog a left join autor b on a.autor = b.sifra
inner join izdavac c on a.izdavac = c.sifra
inner join mjesto d on a.mjesto = d.sifra
where a.naslov like '%ljubav%'; 

-- baza svastara 

use svastara; 

select count(*) from kupci;

select * from kupci where ime = 'Matija';

select distinct ime from kupci where ime ='Matija';
select distinct prezime from kupci where prezime ='Pavković';
