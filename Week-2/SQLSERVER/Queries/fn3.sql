create function fn_getexp(@eid varchar(10))
returns int
as
begin
declare @jd date
declare @experience int
select @jd=JoinDate from Employee where EmployeeId=@eid
set @experience=DATEDIFF(yy,@jd,getdate())
return @experience
end
Go
print dbo.fn_getexp('E0965')
select * from Employee
select EmployeeId,Name,dbo.fn_getexp(EmployeeId) as Exp from Employee