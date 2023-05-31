--query to create stire procedure
create procedure pro1
as
begin
select * from train
end
exec pro1

select * from train
--query to modify stored procedure
alter procedure pro1
as
begin 
select time from train
end
exec pro1

--query for store procedure with parameter
create procedure pro8(@trno as int)
as
begin
select * from train
end
exec pro8 @trno=1234

--query to insert values into procedure
create procedure prod1
as
begin
insert into train values('Raj Exp',1230,444,'Umred','Nagpur',25,3,'ac','sleeper','wating')
end;
exec prod1
select * from train

--query to insert values into stored procedure with paraameter
create procedure prod2(@trn as varchar(20),@trno as int,@pno as int,@or as varchar(20),@dst as varchar(20),@d as int
,@t as int,@cat as varchar(20),@cl as varchar(20),@s as varchar(20))
as
begin
insert into train values(@trn,@trno,@pno,@or,@dst,@d,@t,@cat,@cl,@s)
end;
exec prod2 'mh exp',1234,789,'Nagpur','Ujjain',13,5,'ac','ladies','done'
select * from train

--query to update store procedure with parameter
create procedure prod4(@trn as int)
as begin
update train set TrainNo=@trn
where TrainName='Raj Exp'
end;
exec prod4 0999
select * from train

--query to delete store procedure record
create procedure prod5(@trn as int)
as begin 
delete from train
where TrainName='mh exp'
end;
exec prod5 12
select * from train
