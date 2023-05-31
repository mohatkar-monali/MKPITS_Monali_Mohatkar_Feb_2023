create table student1(rollno int primary key,name varchar(20),email varchar(20),city varchar(20),courseid varchar(20))
insert into student1 values(1,'amit','amit@gmail.com','Nagpur',123)
insert into student1 values(2,'Ram','ram@gmail.com','Nagpur',456)
insert into student1 values(3,'shyam','shyam@gmail.com','Chandrapur',879)
insert into student1 values(4,'aashish','aashish@gmail.com','Gadchiroli',087)
insert into student1 values(5,'tanu','tanu@gmail.com','Amravati',345)
select * from student1

create table fee(feesid int,rollno int constraint cs foreign key(rollno)references student1(rollno),feesdate int,amount int,courseid varchar(20) primary key)
insert into fee values(12,1,1-2-23,5000,89)
insert into fee values(13,2,3-4-23,6000,23)
insert into fee values(14,3,4-5-23,7000,32)
insert into fee values(15,4,3-4-23,4000,90)
insert into fee values(16,5,2-3-23,2000,24)
select * from fee

select feesid,rollno,feesdate,amount,courseid from fee where rollno in (select rollno from student1 where city='Nagpur')
select feesid,rollno,feesdate,amount,courseid from fee where rollno in (select rollno from student1 where city='Chandrapur')

create table course2(courseid varchar(20) constraint css foreign key (courseid)references fee(courseid),coursename varchar(20),fees int,duration int)
insert into course2 values(89,'dotnet',5000,5)
insert into course2 values(23,'dotnet',6000,6)
insert into course2 values(32,'dotnet',78800,7)
insert into course2 values(90,'dotnet',9000,9)
insert into course2 values(24,'java',5000,2)

select courseid,coursename,fees,duration from course2 where coursename='java'
select courseid,coursename,fees,duration from course2 where coursename='dotnet'

select * from course2
--query to update fees
update course2 set fees=90000
where coursename='java'

update course2 set fees=4000
where coursename='dotnnet' and fees=9000

--query to delete column
delete from course2
where coursename='java'

select * from course2

create table sample(id int identity primary key,name varchar(20))
insert into sample values('monali')
insert into sample values('tanushri')
insert into  sample values('anjali')
insert into sample values('karishma')
select * from sample
EXEC sp_rename 'sample.name','newname','COLUMN'
delete  from sample
select * from sample


truncate table sample
insert into sample values('monali')
insert into sample values('tanushri')
insert into  sample values('anjali')
insert into sample values('karishma')
select * from sample

--query to add new column in a table
alter table sample
add rollno int
insert into sample values(1)
select * from sample

--query to change data type of column
alter table sample
alter column rollno dec(10,2)
select * from sample

--query to drop column
alter table sample
drop column rollno
select * from sample

--query to rename the table
sp_rename 'sample' ,'sample1'
select * from sample1

--query to change column name
EXEC sp_rename 'customer.name','studname','column'

