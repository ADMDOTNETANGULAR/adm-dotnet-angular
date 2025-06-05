select * from Project
insert into Project values('P996','KIA Motors')
insert into Project values('P213','Lenovo')
select * from Employee
insert into Employee values('E3453','Mic','2.21.2024','Programmer',25000,null)
insert into Employee values('E3789','Suren','2.10.2024','Sr Programmer',45000,'P996')
insert into Employee values('E3123','Kapil','3.11.2025','Programmer',25000,'P213')
insert into Employee values('E0987','Rohan','4.12.2024','Sr Programmer',45000,null)
insert into Employee values('E5436','Tina','5.13.2023','Programmer',35000,null)
insert into Employee values('E9864','Meena','6.14.2022','TeamLead',95000,'P996')
insert into Employee values('E3420','Charan','6.15.2022','TeamLead',85000,'P213')
insert into Employee values('E3432','Ganesh','7.16.2021','ProjectLead',125000,'P996')

--Update 
update Employee set ProjectCode='P213' where EmployeeId='E0987'
update Employee set ProjectCode='P245',Salary=Salary+10000 where EmployeeId='E3453'
update Employee set Salary=Salary+5000 where ProjectCode='P213'

--Delete
Delete from Employee where EmployeeId='E0987'