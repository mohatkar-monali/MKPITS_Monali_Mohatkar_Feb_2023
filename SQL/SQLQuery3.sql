create table moveis(moviename varchar(20) primary key,showtime int,showdata int)
create table moveidetail(moviename varchar(20),theatername varchar(20),seatno int,constraint c1 foreign key
(moviename) references moveis(moviename))

insert into moveis values('pushpa',9,12)
insert into moveidetail values('pushpa','janki',12)
insert into moveidetail values('pushpa','Raj',24)

insert into moveis values('PK',10,15)
insert into moveidetail values('pk','pvr',25)
insert into moveidetail values('pk','minakshi',54)

insert into moveis values('khaki',6,16)
insert into moveidetail values('khaki','cinemmax',10)

select * from moveis
select * from moveidetail