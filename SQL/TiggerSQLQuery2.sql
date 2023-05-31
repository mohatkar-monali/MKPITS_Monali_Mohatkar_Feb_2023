create table emp1(empid int,empname varchar(20))
create table emplog2(logid int identity(1,1) NOT NULL ,empid int NOT NULL ,operation nvarchar(20) NOT NULL,updatedate datetime NOT NULL )
--query to create triggre (for trigger)
create trigger emptr
on emp1
for insert
as
insert into emplog2(empid,operation,updatedate)
select empid,'insert',GETDATE() from inserted

insert into emp1 values (11,'amit')
insert into emp1 values(12,'amitabh')

select * from emp1
select * from emplog2

--query to create trigger (after trigger) 
create trigger emptr3
on emp1
after update
as
insert into emplog2(empid,operation,updatedate)
select empid,'deleted',GETDATE() from deleted

update emp1 set empname='amrita' where empid=11

select * from emp1
select * from emplog2