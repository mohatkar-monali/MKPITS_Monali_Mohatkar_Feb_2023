--creating table teachers which containn primary key 

create table teachers1(teacher_id int primary key,age int)

--creating table teacher details which contain foreign key

create table teacherdetails1(teacher_id int,subject varchar(20),
constraint cs foreign key (teacher_id) references teachers1(teacher_id))

insert into teachers1 values(25,30)
insert into teacherdetails1 values(25,'Maths')
insert into teacherdetails1 values(25,'physics')

insert into teachers1 values(28,29)
insert into teacherdetails1 values(28,'Chemistry')

insert into teachers1 values(24,31)
insert into teacherdetails1 values(28,'Biology')
insert into teacherdetails1 values(28,'Computer')

select * from teachers1
select * from teacherdetails1