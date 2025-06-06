create table login(uname varchar(10) primary key,pwd varchar(20) not null)
alter trigger tg3
on Employee
after insert
as
declare @eid varchar(10)
select @eid=EmployeeId from inserted
insert into login values(@eid,'12345')
Go
insert into Employee(EmployeeId,Name,Designation,Salary)
values('E8766','Surya','TeamLeader',90000)
select * from login