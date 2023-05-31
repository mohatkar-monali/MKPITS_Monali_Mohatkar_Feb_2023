create table ticket (MovieName varchar(30),TheaterName varchar(30),TicketPrice int,ShowTime int,ShowDate int,SeatNo int) 
insert into ticket values('Pushpa','Pvr',150,12,1-2-23,12)
insert into ticket values('Avengers','Minakshi',180,3,5-2-23,13)
insert into ticket values('Love and Thunder','Raj',200,9,6-2-23,14)
insert into ticket values('Mission Mangal','Janki',150,4,5-2-23,15)
insert into ticket values('PK','Leiberty',250,6,5-2-23,16)
insert into ticket values('WELCOME','Janki',120,6,6-2-23,15)
insert into ticket values('Pavankhind','Raj',110,6,7-2-23,15)
insert into ticket values('Khatta Mittha','Minakshi',200,9,5-2-23,15)
insert into ticket values('Hambirrao','pvr',120,9,8-2-23,15)
insert into ticket values ('kgf','Janki',150,4,5-2-23,15)
select * from ticket
select MovieName from ticket where ShowTime=9 
select MovieName from ticket where TheaterName='RAj' order by ShowDate ,
--this query will arrainge moveiname in accendingorder
select * from ticket order by MovieName
--this query will arrainge moveiname in dccendingorder
select * from ticket order by MovieName desc
--this query will return row of pushpa movie
select * from ticket where MovieName='Pushpa'
select * from ticket where MovieName='Khatta Mittha'
select MovieName from ticket where TicketPrice between 110 and 200
select * from ticket where MovieName like '%sh%'
