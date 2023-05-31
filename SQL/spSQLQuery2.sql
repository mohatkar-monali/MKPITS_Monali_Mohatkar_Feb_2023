select* from students
--qery to get data from student table
create procedure s1
as begin
select * from students
end;
exec s1

--query to find the record of student whose rollno is 222
create procedure prod6
as begin 
select * from students
where std_id=222
end;
exec prod6

--query to get record of stud whose std_id is>111 and <223
create procedure prod8
as begin 
select * from student
where std_id>111 and std_id<223
and first_name='ram'
end;
exec prod8
select * from students

--query to get record from customer and orders table with inner
create proc prodd
as begin
select * from customers c inner join orders o on c.customer_id=o.customer_id
end;
exec prodd



select * from customers
select * from orders

create proc procc
as begin
select * from customers where first_name='tanu' and customer_id=111
end
exec procc

--sp to insert record through parameter
create proc prodf(@cid as int,@fn as varchar(20),@ln as varchar(20),@pn as int,@em as varchar(20),@c as varchar(20)
,@s as varchar(10),@zc as int)
as begin 
insert into customers values(@cid,@fn,@ln,@pn,@em,@c,@s,@zc)
end
exec prodf 12,'monu','dube',23456,'@gmail','pune','mh',246
select * from customers

--sp to update
create proc proff(@cid as int,@fn AS VARCHAR(20),@ln as varchar(20),@pn as int,@em as varchar(20),@c as varchar(20)
,@s as varchar(20),@zc as varchar(20))
as begin
update 