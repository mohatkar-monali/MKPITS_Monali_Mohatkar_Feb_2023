create table salesman(salesman_id int primary key,name varchar(20),city varchar(20),commission dec(10,2))
insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)
select * from salesman

select * from salesman where name='James Hoog' or commission=0.15 
select name,commission from salesman

create table orders( ord_id int,customer_id int primary key(ord_id,customer_id),purch_amt dec(20,2),ord_date varchar(20),salesman_id int 
constraint cst foreign key(salesman_id) references salesman(salesman_id) )
 insert into orders values(70001,3005,150.5,2012-10-05,5002)
 insert into orders values(70009,3001,270.65,2012-09-10,5005)
 insert into orders values(70002,3002,65.26,2012-10-05,5001)
 insert into orders values(70004,3009,110.5,2012-08-17,5003)
 insert into orders values(70007,3005,948.5,2012-09-10,5002)
 insert into orders values(70005,3007,2400.6,2012-07-27,5001)
 insert into orders values(70008,3002,5760,2012-09-10,5001)
 select * from orders

