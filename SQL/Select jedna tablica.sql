-- select list
-- * sve kolone
select * from smjerovi;
-- nazivi colona
select naziv, cijena from smjerovi; 
-- konstanta
select naziv, 'Osijek' from smjerovi;

-- kolonama se može dati zamjensko ime
select naziv as smjer, 'Osijek' as grad from smjerovi;

-- izraz
select naziv, getdate() as datum from smjerovi; 

-- najjednostavniji select
select 1;

-- filtriranje kolona - sve iznad

-- najkomplicirniji primjer
select sifra as s, naziv as n, 'EDUNOVA' as skola, 
len(naziv) as duzina, * from smjerovi; 

-- filtrianje redova -- where dio
select * from smjerovi where sifra=1; 

-- operatori
-- uspoređivanje = >= >  < <= !=
select * from polaznici where sifra !=7; 

select * from polaznici where ime = 'Ivan';

select * from grupe;

select * from grupe where datumPocetka>'2023-09-01';

-- logički operatori

select * from polaznici where sifra>7 and sifra <10;

select * from polaznici where sifra=7 or sifra=10;
select * from polaznici where ime='Ivan' or sifra=10;

select * from polaznici where not ime='Ivan';

-- ostali operatori: like
select * from polaznici where ime not like '%a%';  

-- koji su polaznici s početnim slovom prezimena B

select * from polaznici where prezime like 'b%žić';

-- kaladont
select * from polaznici where prezime like '%nt%';

select * from polaznici where 
sifra =2 or sifra=4 or sifra=7; 
-- jednostavnija sintaksa 
select * from polaznici where sifra in (2,4,7);

select * from polaznici where sifra >=6 and sifra<=10; 
select * from polaznici where sifra between 6 and 10;

select * from grupe where datumpocetka between '2023-01-01' and '2023-12-31';

--  na null vrijednost u tablicama ne može se primjenjivati niti jedan prethodno opisan operator 
select * from smjerovi where brojsati=null;

-- koristi se: is null i is not null
select * from smjerovi where brojsati is null;
select * from smjerovi where brojsati is not null;

select isnull(brojsati,0) from smjerovi;


-- slaganje podataka
select * from polaznici order by prezime;
select * from polaznici order by prezime desc;
select * from polaznici order by prezime desc, 2 desc;

-- limitiranje podataka 
select top 10 * from polaznici; 
select top 10 percent * from polaznici;


select ime as djever, brojugovora as racun into nova from polaznici;
select*from nova;

drop table nova;
