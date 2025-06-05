--group by syntax
-- select col1,Aggregate_fn(col2) from table group by col1
--Total quantity per order
select * from sales.order_items
select order_id,SUM(quantity) as 'Total qty' from sales.order_items group by order_id 
select order_id,SUM(quantity) as 'Total qty' from sales.order_items group by order_id  order by [Total qty]
--Order qunatity >5
select order_id,SUM(quantity) as 'Total qty' from sales.order_items group by order_id having sum(quantity)>=5  order by [Total qty]
select order_id,SUM(quantity*list_price) as 'Total Price' from sales.order_items group by order_id 
select order_id,SUM(quantity*list_price) as 'Total Price' from sales.order_items group by order_id having SUM(quantity*list_price)>5000
select * from sales.customers
select city,count(customer_id) as 'Total Customers' from sales.customers group by city 
select city,count(customer_id) as 'Total Customers' from sales.customers 
where city<>'Selden'  group by city 
select city,state,count(customer_id) as 'Total Customers' from sales.customers group by city,state