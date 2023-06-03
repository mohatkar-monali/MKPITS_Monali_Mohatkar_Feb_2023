select * from orders
select * from product
select * from salesman
--query for inner join--
select o.customer_id,o.purch_amt,s.name from orders o inner join salesman s on o.salesman_id=s.salesman_id;

--query for left join--
select o.customer_id,o.purch_amt,s.name from orders o left join salesman s on o.salesman_id=s.salesman_id;

--query for right join
select o.customer_id,o.purch_amt,s.name from orders o right  join salesman s on o.salesman_id=s.salesman_id;

--query for full join--
select o.customer_id,o.purch_amt,s.name from orders o full join salesman s on o.salesman_id=s.salesman_id;
