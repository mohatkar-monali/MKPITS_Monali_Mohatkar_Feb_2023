CREATE TABLE Item_Master(Item_Id int primary key identity,Item_Name varchar(500) Not Null,Category varchar(500) Not Null,Rate int,Balance_Quantity int not null)

create table DEpartment_Master(Department_Id int primary key identity,Department_Name varchar(500) not null)

create table Vendor_Master(Vendor_Id  int primary key identity,Vendor_Name varchar(500) not null)

create table Transaction_Details(Transaction_Id int primary key identity,Item_Id int constraint c1 foreign key(Item_Id)references Item_Master(Item_Id),
TransactionDate DateTime not null,Department_Id int constraint c2 foreign key(Department_Id)references Department_Master(Department_Id),
Vendor_Id int constraint c3 foreign key (Vendor_Id)references Vendor_Master(Vendor_Id),Quantity int not null)