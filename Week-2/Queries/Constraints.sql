--Create table with constraints
create table Project(ProjectCode char(4) primary key ,ProjectName varchar(20) not null unique )
insert into Project(ProjectCode,ProjectName) values('P245','ClicCart')
insert into Project(ProjectCode,ProjectName) values('P211','ABC School')
select * from Project
sp_help Project
create table Employee(EmployeeId char(5) primary key,[Name] varchar(30) not null,
JoinDate Date check(JoinDate<getdate()),Designation varchar(20) default 'Employee',
Salary int check(Salary>10000),ProjectCode char(4),
constraint fk_projectcode Foreign key(ProjectCode) references Project (ProjectCode))
insert into Employee(EmployeeId,Name,JoinDate,Salary,ProjectCode) values(
'E4567','Karan','3.21.2020',50000,'P245')
insert into Employee(EmployeeId,Name,JoinDate,Designation,Salary,ProjectCode) values(
'E4578','Jeson','3.12.2023','Programmer',35000,'P211')
select * from Employee