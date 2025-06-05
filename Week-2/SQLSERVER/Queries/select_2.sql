select * from production.products
select * from production.products where model_year between 2017 and 2018
select * from production.products where list_price between 100 and 1000
select * from production.products where list_price not between 100 and 1000
select * from sales.orders
select * from sales.orders where order_date between '4.1.2016' and '4.30.2016'
select * from sales.customers
select * from sales.customers where first_name like 'd%' -- name starts with d
select * from sales.customers where first_name like '%i' --name ends with i
select * from sales.customers where first_name like '%o%' --name contains o
select * from sales.customers where first_name like '[a-d]%' --name starts with a b c d
select * from sales.customers where first_name like '[sijb]%'
select * from sales.customers where first_name not like '[sijb]%'
select * from sales.customers where first_name like '_a%' --name starts with 2nd char a
select * from sales.customers order by city --default ascending order
select * from sales.customers where first_name like 'd%' order by city asc
select * from sales.customers where first_name like 'd%' order by city desc
select * from sales.customers where first_name like 'd%' order by state,city

