create database MoneyBank

create table passwords
(
username varchar(100) not null,
passwords varchar (8) not null,
);

insert into passwords(username,passwords)
values  ('Sasindu','12345678'),
		('pasindu','01234567'),
		('anudi','78945612');

create table AccountCreated 
(
Ininame varchar (100),
Fullname varchar (300),
Addresss varchar (300),
NicBisNo varchar (15),
);

create table customer
(
username varchar (20) not null primary key,
passwors varchar (8) not null,
Amount varchar (20),
);

ALTER TABLE customer ALTER COLUMN Amount DECIMAL(18, 2);
ALTER TABLE customer ADD TransferAccNumber VARCHAR(20);


select * from passwords
select * from AccountCreated
select * from customer

DELETE FROM AccountCreated WHERE (Ininame = '');
