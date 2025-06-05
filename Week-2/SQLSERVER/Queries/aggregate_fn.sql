--Aggregate functions
-- Count(),Sum(),Avg(),Min(),Max()
select count(*) as 'Customers' from sales.customers
select count(customer_id) from sales.customers where state='NY'
select * from sales.order_items
select sum(quantity) as 'Total Qunatity' from sales.order_items where order_id=1
select sum(quantity*list_price) as 'Total Price' from sales.order_items where order_id=1
select avg(quantity) from sales.order_items
select * from production.products
select max(list_price) as 'Max Price' from production.products
select min(list_price) as 'Max Price' from production.products