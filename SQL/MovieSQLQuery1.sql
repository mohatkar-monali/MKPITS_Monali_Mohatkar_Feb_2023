

select * from tableproduct
select * from tableproductcategory

create table Theater(TheaterId int primary key,TheaterName varchar(20))
insert into Theater values(11,'Liberty')
insert into Theater values(12,'Smruti')
insert into Theater values(13,'Inox')

create table movie(MID int constraint c9 foreign key(MID)references Theater(TheaterId), Movie_Name varchar(20),show_Time varchar(20),price int)
insert into movie values(11,'Pushpa',12-00,200)
insert into movie values(11,'PK',9-00,150)
insert into movie values(11,'Ved',6-00,250)
insert into movie values(12,'Bhola',9-00,100)
insert into movie values(12,'Avtar',10-00,300)
insert into movie values(13,'Pushpa',12-00,100)
insert into movie values(13,'Pushpa',6-00,200)

select * from Theater
select* from movie
select m.Movie_Name from movie m inner join theater t on m.mid=t.theaterid where theatername='Smruti';
select TheaterName from Theater
select price from movie where Movie_Name='Pushpa'
update movie set price=250 where MID=13
update movie set price=350 where show_Time=6
select price from movie where Movie_Name='Pushpa'
select show_Time from movie where Movie_Name='Pushpa'

create table BookingDetails(Name varchar(50),ContactNo varchar(10),
Gender varchar(10),TheaterName varchar(50),MovieName varchar(50),ShowTime varchar(20)
,No_Of_Seat int,Price int,Date datetime)