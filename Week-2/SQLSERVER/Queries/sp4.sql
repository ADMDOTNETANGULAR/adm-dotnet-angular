alter procedure sp_GetEmployeesByProjectCode(@PCode varchar(5))
as
begin
begin try
if(exists(select * from Employee where ProjectCode=@PCode))
select * from Employee where ProjectCode=@PCode
else
print 'Invalid Project Code'
end try
begin catch
select 'Error Occured'
end catch
end
select * from Employee
exec sp_GetEmployeesByProjectCode 'P2134'