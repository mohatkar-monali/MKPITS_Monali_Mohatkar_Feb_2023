--creating table store which contain primary key
create table stores(store_id int primary key,store_name varchar(20),phone int,email varchar(20),street varchar(20),
city varchar(20),state varchar(20),zipcode int)

--inserting values into store table
insert into stores values(4566,'Haldiram',5678,'haldiram.com','Nagpur road','Nagpur','Maharashtra',441107)

--creating table categories contain primary key category_id
create table categories(category_id int primary key,category_name varchar(20))
--inserting value into categoreis table
insert into categories values(6789,'sweet')

--creating table brand which contain primary key brand_id
create table brands(brand_id int primary key,brand_name varchar(20))
--inserting value into brands table
insert into brands values(456,'Haldiram')

--creating table products which contain primary key product_id and foreign key brand_id,category_id
create table products(product_id int primary key,product_name varchar(20),brand_id int,category_id int,
model_year int,list_price int,constraint c1 foreign key(brand_id) references brands(brand_id),
constraint c2 foreign key(category_id) references categories(category_id))
--inserting values into product table
insert into products values(45,'Rasmalai',456,6789,1999,200)

--creating table stocks which contain foriegn key store_id
create table stocks(store_id int,product_id int,quantity int,constraint c3 foreign key(store_id) references
stores(store_id),constraint c4 foreign key(product_id) references products(product_id))
--inserting values into stocks table
insert into stocks values(4566,45,4)

--creating table customers which contain primary key customer_id
create table customers(customer_id int primary key,first_name varchar(20),last_name varchar(20),phone int,email varchar(10),
city varchar(20),state varchar(20),zip_code int)
--inserting values into customers table
insert into customers values(111,'tanu','meshram',345667,'tanugmail','Chandrapur','Maharashtra',445869)

--creating table staff which contain primary key staff_id and foreign key store_id
create table staff(staff_id int primary key,first_name varchar(20),last_name varchar(20),email varchar(20),
phone int,active varchar(20),store_id int,manager_id int,constraint t1 foreign key(store_id)references stores(store_id))
--inserting values into staff table
insert into staff values(33,'ram','pachdhare','ram@gmail.com',56784,'present',4566,51)

--creating table orders which contain primary key order_id and foreign key customer_id,staff_id
create table orders(order_id int primary key,customer_id int,order_status varchar(20),order_date int,required_date int,shipped_date
int,store_id int,staff_id int,constraint or1 foreign key(customer_id)references customers(customer_id),
constraint o4 foreign key(store_id)references stores(store_id),constraint o5 foreign key(staff_id)references staff(staff_id))
--inserting values into staff table
insert into orders values(77,111,'done',12-3-23,17-3-23,13-3-23,4566,33)

--creating table order_item which contain foreign key order_id and product_id
create table oder_item(order_id int,item_id int,product_id int,quantity int,lait_price int,discount float
constraint i1 foreign key(order_id)references orders(order_id),constraint i2 foreign key(product_id)references products(product_id))
--inserting values into staff table
insert into oder_item values(77,34,45,3,800,0.10)

select*from stores
select*from categories
select*from brands
select*from products
select*from stocks
select*from customers
select*from staff
select*from orders
select*from oder_item