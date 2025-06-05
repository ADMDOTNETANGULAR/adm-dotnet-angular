select * from Employee
create view vw_Employee
as
--mention columns
select EmployeeId,Name,JoinDate,Designation from Employee
Go
select * from vw_Employee
select EmployeeId,Name from vw_Employee
select * from vw_Employee where Designation='Programmer'
update vw_Employee set Designation='Sr Programmer' where EmployeeId='E3123'