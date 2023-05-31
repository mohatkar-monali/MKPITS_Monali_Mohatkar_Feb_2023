create table student1 (rollno int,first_name varchar(50),last_name varchar(50),course varchar(50),city varchar(50),state varchar(50))
insert into student1 values(1,'Anjali','Pathak','DotNet','Nagpur','Bihar')
insert into student1 values(2,'Tanu','Meshram','DotNet','Bhandara','Maharashtra')
insert into student1 values(3,'karsihma','Pachdhare','DotNet','Nagpur','Maharshtra')
insert into student1 values(4,'Yasmin','Sheikh','DotNet','Chandrapur','Maharshtra')
insert into student1 values(5,'Jay','Deshmukh','DotNet','Amravati','Maharashtra')
insert into student1 values(6,'Tanmay','Patil','DotNet','Nagpur','Maharashtra')
insert into student1 values(7,'Sahil','Kalwe','DotNet','Nagpur','Maharashtra')
select * from student1
--query to find first name from student table
select first_name from student1
--query to find first name and last name
select first_name , last_name from student1
--query to find table
select * from student1
--query to arrange data in accending order
select * from student1 order by first_name
--query to arrange data in decending order
select * from student1 order by first_name desc
--query to find records whoes name is Anjali
select * from student1 where first_name='Anjali'
--query to find records whoes city is Nagpur
select * from student1 where city='Nagpur'
--query to find record whoes rollno is 1
select * from student1 where rollno=1
--query to find the record whoes rollno is >1
select * from student1 where rollno>1
--query to find the record whoes rollno is >1 and <=5
select * from student1 where rollno>1 and rollno<=5 
--query to find the record whoes fname and lname is tanu meshram
select * from student1 where first_name='Tanu' and last_name='Meshram'
--query to count no of student on course whoes city is nagpur
select course , count(*) from student1 where city='Nagpur' group by course
--query to count no of student on course whoes city is nagpur in accending order
select course , count(*) from student1 where state='Maharashtra' group by course order by course
--query to count no of student on course whoes city is nagpur 
select course , count(*) from student1 where state='Maharashtra' group by course order by course having count(*)>2