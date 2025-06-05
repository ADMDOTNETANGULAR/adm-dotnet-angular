create procedure sp_AddEmployee(@id char(5),@name varchar(20),@jd date,@salary int)
as
begin
begin try
if(exists(select * from Employee where EmployeeId=@id))
print 'Employee with '+@id+' id already exist'
else
insert into Employee(EmployeeId,Name,JoinDate,Salary) values(@id,@name,@jd,@salary)
end try
begin catch
select ERROR_MESSAGE() as Message
end catch
end
exec sp_AddEmployee 'E0965','Ram','2.12.2023',33000
select * from Employee