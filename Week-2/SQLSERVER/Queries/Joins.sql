--Joins
--Joins are used to combine rows from two or more tables based on related columns.
--Inner Join -  Returns only matching rows from both the tables
--Left Outer Join - Returns all rows from left table and matching rows from right
--Rigt Outer Join - Retruns all rows from right table and matchig rows from left
--Full Outer Join - Returns all the rows when there is a match in one of the tables
--Cross Join - Return Cartesian product (every row in one table with every row in another)
--Self Join - Joining the table it self
select * from Project
insert into Project values('P998','Project-k')
insert into Project values('P798','Project-x')
select * from Employee
select e.EmployeeId,e.Name,e.Designation,p.ProjectName
from Employee e join Project p 
on e.ProjectCode=p.ProjectCode
select e.EmployeeId,e.Name,e.Designation,p.ProjectName
from Employee e join Project p 
on e.ProjectCode=p.ProjectCode where p.ProjectName='Lenovo'
select e.EmployeeId,e.Name,e.Designation,p.ProjectName
from Employee e join Project p 
on e.ProjectCode=p.ProjectCode where p.ProjectName='Lenovo' order by e.Name
select e.EmployeeId,e.Name,e.Designation,p.ProjectName
from Employee e join Project p 
on e.ProjectCode=p.ProjectCode where e.ProjectCode=(select p.ProjectCode from Project p where p.ProjectName='Lenovo') order by e.Name
--Left outer join
select e.EmployeeId,e.Name,e.JoinDate,p.ProjectCode,p.projectName from 
Employee e left outer join Project p
on e.ProjectCode=p.ProjectCode
--Right outer join
select e.EmployeeId,e.Name,e.JoinDate,p.ProjectCode,p.projectName from 
Employee e right outer join Project p
on e.ProjectCode=p.ProjectCode
--Full outer join
select e.EmployeeId,e.Name,e.JoinDate,p.ProjectCode,p.projectName from 
Employee e full outer join Project p
on e.ProjectCode=p.ProjectCode
--Cross Join
select e.Name,p.projectName from Employee e cross join Project p
select * from Employee
alter table Employee add Manager char(5) foreign key references Employee(EmployeeId)
update Employee set Manager='E9864' from Employee where EmployeeId in('E5436','E4578','E4567','E3789')
select Name,Manager from Employee
select A.Name as Manager,B.Name as Report
from Employee A
join Employee B
on A.EmployeeId=B.Manager
--Join 3 tables
select * from sales.customers
select * from sales.orders
select * from sales.stores
select * from sales.staffs
select c.customer_id,o.order_id,s.store_name as storeName,st.first_name as StaffName from sales.customers c
join sales.orders o on c.customer_id=o.customer_id
join sales.stores s on o.store_id=s.store_id
join sales.staffs st on o.staff_id=st.staff_id

