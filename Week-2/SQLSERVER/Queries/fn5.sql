alter function fn_GetEmployeesByProject(@pcode varchar(10))
returns table
as
return select Employee.EmployeeId,Employee.Name,Project.ProjectName from Employee
inner Join Project on Employee.ProjectCode=Project.ProjectCode where Employee.ProjectCode=@pcode
Go
select * from fn_GetEmployeesByProject('P245')