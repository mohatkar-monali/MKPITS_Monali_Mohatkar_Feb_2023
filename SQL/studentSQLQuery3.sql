create table courses(course_id int primary key,course_name varchar(20))
insert into courses values(1,'Dotnet')
insert into courses values(2,'java')
create table students(rollno int primary key,studname varchar(20),course_id int constraint ct foreign key(course_id)references courses(course_id))
insert into students values(1,'ram',1)
insert into students values(2,'shyam',1)
insert into students values(3,'amit',2)
insert into students values(4,'aashish',2)
select * from students

select studname from students where course_id=(select course_id from courses where course_name='Dotnet')
select studname from students where course_id=(select course_id from courses where course_name='java')

select st.studname
from students st  inner join courses cs
on cs.course_id=st.course_id
where course_name='dotnet'

select st.studname
from students st inner join courses cs
on st.course_id=cs.course_id
where course_name='java'