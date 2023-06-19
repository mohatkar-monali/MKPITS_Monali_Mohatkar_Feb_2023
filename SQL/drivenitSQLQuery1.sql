create table ItemMaster(ItemId int primary key identity not null,Itemdesc varchar(500) null,BalQty int,createon datetime)

create table Transactions(Transid int primary key identity,ItemId int constraint c1 foreign key (ItemId) references ItemMaster 
(Itemid) not null,TransType varchar(10) not null,TransQty int,TranseDate datetime)

insert into ItemMaster values('Mouse',10,'12/12/2023')
insert into ItemMaster values('Keyboard',20,'12/12/2023')

select * from ItemMaster