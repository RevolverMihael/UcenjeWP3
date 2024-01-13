use master;
go
drop database if exists djecji_vrtic;
go
create database djecji_vrtic;
go
use djecji_vrtic;

--drop table odgojna_skupina;

create table skupina (
sifra int primary key identity (1,1),
naziv varchar (50) not null,
odgajateljica int not null,
dijete int not null
);

create table djeca (
sifra int primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
ime_roditelja varchar (50) not null
);

create table odgajateljice (
sifra int primary key identity (1,1),
ime varchar (50) not null,
prezime varchar (50) not null,
oib char (11),
datum_rodjenja datetime
);

create table strucna_sprema (
sifra int primary key identity (1,1),
odgajateljica int,
titula bit not null
);

alter table skupina add foreign key (odgajateljica) references odgajateljice(sifra);
alter table skupina add foreign key (dijete) references djeca(sifra);
alter table strucna_sprema add foreign key (odgajateljica) references odgajateljice(sifra);

select * from skupina;


insert into djeca (ime, prezime, ime_roditelja) values 
--1
('Tin','Sedlar','Katarina'),
--2
('Enis','Car','Marija'),
--3
('Igor','Belan','Sara'),
--4
('Petar','Bor','Goran');

insert into skupina (naziv, odgajateljica, dijete) values
('Zlatne dame',1,4);

select * from odgajateljice;

select * from skupina;


insert into odgajateljice (ime, prezime, datum_rodjenja) values
--1 do 2
('Ivana','Seselj','1980-07-24 19:00:00'),
('Vanja','Bare','1950-04-08 14:00:00');

insert into strucna_sprema (titula)
values (1);

select * from strucna_sprema;





