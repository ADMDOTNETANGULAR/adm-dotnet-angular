select * from sales.customers
select customer_id,first_name,last_name from sales.customers
select customer_id,first_name+' '+last_name as 'full_name' from sales.customers
select * from sales.customers where customer_id=9
select * from sales.customers where city='Fairport'
select * from sales.customers where state='CA'
select * from sales.customers where state='CA' and city='Oakland'
select * from sales.customers where city='Fairport' or city='Oakland'
select * from sales.customers where city in('Fairport','Oakland','Buffalo')
select * from sales.customers where city not in('Fairport','Oakland','Buffalo')
select * from sales.customers where phone is null