--creating a table ordert which contain primary key(2NF)
create table ordert(orderno int primary key,orderdate varchar(30),custid int)
--creat ing table orderid  which contain foreign key(2NF)
create table orderid(orderno int,prodid int,rate int,quantity int,
constraint c1 foreign key(orderno)references ordert(orderno))

insert into ordert values(1,12/12/22,212)
insert into orderid values(1,123,200,2)
insert into orderid values(1,124,500,1)

insert into ordert values(2,12/1/23,213)
insert into orderid values(2,123,200,1)
insert into orderid values(2,125,600,2)

insert into ordert values(3,13/2/23,214)
insert into orderid values(3,125,600,1)

select *from ordert
select * from orderid