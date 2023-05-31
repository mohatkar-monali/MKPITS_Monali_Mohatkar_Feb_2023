create table students(std_id int,admission_no int,first_name varchar(20),
last_name varchar(20))
insert into students(std_id,admission_no,first_name,last_name)values
(111,11,'ram','dube'),(222,12,'shyam','pathak'),
(333,13,'rm','be'),(223,14,'shy','pk')

create table fees(adm_no int,fees_paid int)
insert into fees(adm_no,fees_paid)values(11,4000),(12,5000),(13,7000),(16,2000)
select * from students
select * from fees
--query for inner join
select s.admission_no,s.first_name,f.adm_no,f.fees_paid
from students s
inner join fees f on s.admission_no=f.adm_no
--query for cross join
select s.admission_no,s.first_name,f.adm_no,f.fees_paid
from students s
inner join fees f on s.admission_no=f.adm_no
--query for left join
select s.admission_no,s.first_name,f.adm_no,f.fees_paid
from students s
left join fees f on s.admission_no=f.adm_no
--query for right join
select s.admission_no,s.first_name,f.adm_no,f.fees_paid
from students s
right join fees f on s.admission_no=f.adm_no
--query for full join
select s.admission_no,s.first_name,f.adm_no,f.fees_paid
from students s
full join fees f on s.admission_no=f.adm_no