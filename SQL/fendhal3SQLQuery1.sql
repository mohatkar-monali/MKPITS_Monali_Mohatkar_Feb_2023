create table TableProductGstDetails(Product_Gst_Id int primary key,Gst_Detail_Name varchar(500),CGST decimal,SGST decimal)
insert into TableProductGstDetails values(601,'AC and Fridge',14,14)
insert into TableProductGstDetails values(602,'Computers',9,9)
insert into TableProductGstDetails values(603,'Printers',9,9)
insert into TableProductGstDetails values(604,'Mobiles',6,6)

create table TableProductCategory(Product_Category_Id int primary key,Product_type_Name varchar(500),Product_Gst_id int constraint pc foreign key(Product_Gst_Id) 
references TableProductGstDetails(Product_Gst_Id))
insert into TableProductCategory values(1001,'Computers',602)
insert into TableProductCategory values(1002,'Mobile',604)
insert into TableProductCategory values(1003,'Printers',603)
insert into TableProductCategory values(1004,'AC and Fridge',601)


create table TableProduct(Product_Id int primary key,ProductTypeId int constraint tp foreign key(ProductTypeId)references TableProductCategory(Product_Category_Id)
,Product_Name varchar(500),Available_Quantity int,Total_Quantity int)
insert into TableProduct values(210,1002,'Apple',100,80)
insert into TableProduct values(211,1002,'Lenevo',200,150)
insert into TableProduct values(212,1003,'Samsung',150,100)
insert into TableProduct values(213,1004,'IFB',80,50)
insert into TableProduct values(214,1004,'LG',90,80)
insert into TableProduct values(215,1001,'Sony',50,30)
alter  table TableProduct add price decimal
select * from TableProduct
update TableProduct set Available_Quantity=100 where Product_Name='Apple'
update TableProduct set price=2 where Product_Name='Lenevo'
update TableProduct set price=50000 where Product_Name='Samsung'
update TableProduct set price=20000 where Product_Name='IFB'
update TableProduct set price=30000 where Product_Name='LG'
update TableProduct set price=60000 where Product_Name='Sony'

update TableProduct set Available_Quantity= where Product_Name='Apple'
update TableProduct set price=25000 where Product_Name='Lenevo'
update TableProduct set price=50000 where Product_Name='Samsung'
update TableProduct set price=20000 where Product_Name='IFB'
update TableProduct set price=30000 where Product_Name='LG'
update TableProduct set price=60000 where Product_Name='Sony'
select Available_Quantity from TableProduct where Product_Name='Apple' 

create table TableInvoiceDetails(Invoice_Detail_Id int primary key identity,Customer_Name varchar(500),Customer_Contact varchar(15),Product_Category_Id int constraint c3 
foreign key(Product_Category_Id)references TableProductCategory(Product_Category_Id),Product_Id int constraint c4 foreign key(Product_Id)references 
TableProduct(Product_Id),Gender Varchar(500),Invoice_Date datetime,Quantity decimal,Price decimal,CGST decimal,SGST decimal,
CGST_Value decimal,SGST_Value decimal,Total_Amount decimal)
insert into TableInvoiceDetails values('Rahul',9852132210,1002,210,3001,2023-04-04,1,50000,6,6,12,3000,3000,6000,56000) 
insert into TableInvoiceDetails values('Nikita',7861232210,1001,211,3002,2023-04-08,1,65000,9,9,18,11700,5850,5850,76700)
insert into TableInvoiceDetails values('Gopal',1234567890,1001,215,3003,2023-04-12,1,60000,9,9,18,5400,5400,10800,70800)
insert into TableInvoiceDetails values('Anand',1234567890,1002,210,3004,2023-04-12,1,40000,6,6,6,2400,2400,2400,42400) 
select* from TableInvoiceDetails