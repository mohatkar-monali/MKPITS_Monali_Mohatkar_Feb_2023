create table items(item varchar(20) default 'SAMOSA')
insert into items values('Barfi')
select * from items

---query to add default value
create table menues(item varchar(20) default 'RASMALI',item_id int,time int)
insert into menues values('kachori',123,12)
insert into menues (item_id,time)values(34,14),(23,55),(970,14)
select * from menues

create table item1(item_no int,item_name varchar(20) constraint df default 'dhokla')
insert into item1(item_no)values(101)
select *from item1

--query to drop default value
alter table item1
drop constraint df
insert into item1(item_no)values(104)
select *from item1

