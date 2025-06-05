--Create view with columns from multipls tables
alter view vw_EmployeeProject
as
select Employee.EmployeeId,Employee.Name,Project.ProjectName,Project.ProjectCode
from Employee join Project on Employee.ProjectCode=Project.ProjectCode
Go
select * from vw_EmployeeProject
select * from vw_EmployeeProject where ProjectName='Lenovo'
select * from vw_EmployeeProject order by Name asc
select count(*) from vw_EmployeeProject

drop view vw_EmployeeProject
sp_helptext vw_EmployeeProject