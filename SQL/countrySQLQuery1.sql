create table country(country_id int primary key,country_name varchar(20))
create table state(state_id int primary key,state_name varchar(20),country_id int constraint c1 foreign key(country_id)references country (country_id))
insert into country values(1,'USA')
insert into country values(2,'India')
insert into state values(11,'Washington',1) 
insert into state values(12,'Texas',1) 
insert into state values(13,'Maharashtra',2)
insert into state values(14,'MP',2)

create table city(city_id int primary key,city_name varchar(20),state_id int constraint c2 foreign key(state_id)references state(state_id))
insert into city values(22,'LA',11)
insert into city values(23,'Algam',12)
insert into city values(24,'Nagpur',13)
insert into city values(25,'Mumbai',13)
insert into city  values(26,'Bhopal',14)
insert into city values(27,'Indore',14)

select * from country
select * from state
select * from city

select c.country_id,c.country_name,s.state_name
from country c inner join state s
on c.country_id=s.country_id
where c.country_name='India'

select c.country_id,c.country_name,s.state_name
from country c inner join state s
on c.country_id=s.country_id
where c.country_name='USA'

select s.state_name
from country c inner join state s
on c.country_id=s.country_id
where c.country_name='India'

select s.state_name
from country c inner join state s
on c.country_id=s.country_id
where c.country_name='USA'

select ct.city_name 
from city ct inner join state s
on ct.state_id=s.state_id
where s.state_name='Maharashtra'

select ct.city_name
from city ct inner join state s
on ct.state_id=s.state_id
where s.state_name='MP'

select ct.city_name
from city ct inner join state s
on ct.state_id=s.state_id
where s.state_name='Texas'

select ct.city_name
from city ct inner join state s
on ct.state_id=s.state_id
where s.state_name='Washington'

select state_name from state where country_id=(select country_id from country where country_name='India')
select state_name from state where country_id=(select country_id from country where country_name='USA')

select city_name from city where state_id=(select state_id from state where state_name='Maharashtra')
select city_name name from city where state_id=(select state_id from state where state_name='MP')
select city_name from city where state_id=(select state_id from state where state_name='Washington')
select city_name from city where state_id=(select state_id from state where state_name='Texas')





