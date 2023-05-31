--query for  inner join
select c.customer_id,c.first_name,o.order_id,o.customer_id
from customers c inner join orders o on c.customer_id=o.customer_id

--query for cross join 
select c.customer_id,c.first_name,o.order_id,o.customer_id
from customers c cross join orders o where c.customer_id=o.customer_id

--query for left join
select c.customer_id,c.first_name,o.order_id,o.customer_id
from customers c left join orders o on c.customer_id=o.customer_id

--query for right join
select c.customer_id,c.first_name,o.order_id,o.customer_id
from customers c right join orders o on c.customer_id=o.customer_id

--query for full join
select c.customer_id,c.first_name,o.order_id,o.customer_id
from customers c full join orders o on c.customer_id=o.customer_id 

select * from customers
select * from orders
