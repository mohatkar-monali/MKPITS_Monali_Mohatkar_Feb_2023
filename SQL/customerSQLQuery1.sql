create table customer(customerid int primary key,firstname varchar(20),lastname varchar(20),phone int,email varchar(20),
street varchar(20),city varchar(20),state varchar(20),zipcode int)
insert into customer values(12,'amit','shrivastav',45678943,'amit@gmail.com','nagpur road','Nagpur','Maharashtra',45678)
insert into customer values(13,'sbyam','pathak',45456243,'shyam@gmail.com','walkin road','Chandrapur','Maharashtra',45333)
insert into customer values(14,'ksrishma','shrivastav',4980754,'karishma@gmail.com','bhopal road','Bhopal','Mp',412378)
insert into customer values(15,'tanu','pachdhare',45646943,'tanu@gmail.com','plioce line road','Indore','Mp',09239)
select * from customer

create table orders(orderid int,customerid int constraint t1 foreign key(customerid)references customer(customerid),orderstatus varchar(10)
,orderdate int,shippeddate int)
insert into orders values(144,12,'packed',3-23,4-23)
insert into orders values(133,13,'shipped',4-23,9-23)
insert into orders values(123,14,'arrive',3-23,9-23)



select customerid,firstname,lastname from customer where state='Maharashtra'
select orderid,customerid,orderdate from orders where customerid in(select customerid from customer where state='Maharashtra')

select * from customer