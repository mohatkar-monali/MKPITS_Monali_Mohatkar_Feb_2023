--creating a table order_detail which contain composite key 
create table order_detail(order_id int,product_id varchar(20),quantity int
,primary key(order_id,product_id))
insert into order_detail values(11,33,5)
insert into order_detail values(11,34,4)
insert into order_detail values(12,35,4)
select*from order_detail

--creating table employee which contain unique key
create table employee1(empid int unique,empname varchar(20))
insert into employee1(empname) values('shyam')--it assign a null value
insert into employee1 values(11,'shyam')
insert into employee1 values(11,'shreya')--empid should be different
insert into employee1 values(13,'shyam')
select*from employee1

create table employee2(empname varchar(20),empid int,aadharno int,unique(empid,aadharno))
insert into employee2 values('ram',123,3445567)
insert into employee2 values('ram',123,3445567)--not possible one value should be different
insert into employee2 values('ram',124,3445567)
insert into employee2 values('ram',123,3349980)
select*from employee2

create table employee3(empid int primary key,empname varchar(20),
passportno int,drivinglicenceno int,
constraint e1 unique(passportno,drivinglicenceno))

insert into employee3 values(1,'jayesh',12345,98989)
insert into employee3 values(9,'jayesh',4567,12389

create table customer1(custid int primary key identity,custname varchar(50))

insert into customer1 values('raj')
select * from customer1
insert into customer1 values('rajesh')
select * from customer1

create table products(product_id int primary key,product_name varchar(20) not null,unit_price dec(10,2)check (unit_price>0))
insert into products values(19,'mouse',120)
insert into products values(112,'mouse',0)--unit price should be >0

create table products2(product_id int primary key,product_name varchar(20) not null,unit_price dec(10,2)check (unit_price>0))
insert into products2 values(19,120)--it should contain value
insert into products2 values(19,'mouse',120)

alter table products2 
add discounted_price
dec(20,2)
select*from products2

alter table products2

drop constraint product_id
EXEC sp_HELP 'products2'
 
 select * from train
 --quary to find min PNRNO
 select MIN(PNRNO)from train
 --quary to find min PNRNO of Maharaja Express
 select MIN(PNRNO)from train where TrainName='Maharaja Express'
 select distinct MIN(PNRNO)from train
 select distinct MAX(PNRNO)from train
 select TrainName , MIN(PNRNO) as 'pnrno' from train where PNRNO=93  group by TrainName 
 select TrainName,TrainNo from train where PNRNO=(select MIN(PNRNO) from train)
 select * from train