-- izlistajte imena i prezimena autora

select ime, prezime from autor; 

select top 10 ime, prezime from autor;

-- koliko ima redova u tablici autor
select count(*) from autor;

-- izlistajte sve autore koji su rođeni u 
-- Vašoj godini rođenja

select * from autor where datumrodenja between '1988-01-01' and '1988-12-29';

-- unesite sebe kao autora
insert into autor(sifra, ime, prezime, datumrodenja) values
(5623, 'Matija', 'Pavković', '1988-07-01');

select * from katalog where (naslov like '%bol%' or naslov like '%ljubav%') and sifra not in(2541, 2596, 2680);


-- izlistajte sve neaktivne izdavače
select * from izdavac where aktivan =0;

-- izlistajte sve izdavače koji su d.o.o.

select * from izdavac where naziv like '%d%o%o%';

-- izlistajte sva mjesta u osječko baranjskoj županiji 
select * from mjesto where postanskibroj like '31%';

-- s najmanjom pogreškom 
-- izlistajte sve autorice

select * from autor where ime like '%a';

select distinct ime from autor where ime like '%a';


