select * from Project
select * from Employee
select Max(Salary) from Employee
select * from Employee where Salary=Max(Salary)
select * from Employee where Salary=(select Max(Salary) from Employee)
select * from Employee where Salary=(select Min(Salary) from Employee)
select * from Employee where ProjectCode=(select ProjectCode from Project where ProjectName='ClicCart')
select * from Employee where ProjectCode in(select ProjectCode from Project where ProjectName in('ClicCart','ABC School'))
select * from Employee where ProjectCode not in(select ProjectCode from Project where ProjectName in('ClicCart','ABC School'))
--get employees who are getting grater salary than all employees in clicCart
select * from Employee where Salary>All
(select salary from Employee where ProjectCode=
(select ProjectCode from Project where ProjectName='ClicCart'))
select * from Employee where Salary<All
(select salary from Employee where ProjectCode=
(select ProjectCode from Project where ProjectName='ClicCart'))