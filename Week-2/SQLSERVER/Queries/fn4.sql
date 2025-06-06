create function fn_getEmployeeByProject(@pcode varchar(10))
returns table
as
return select * from Employee where ProjectCode=@pcode
Go
select * from fn_getEmployeeByProject('P245')
select Name,JoinDate from fn_getEmployeeByProject('P245')
select * from fn_getEmployeeByProject('P245') where Salary>20000
select * from Project
