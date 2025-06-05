--Stored Procedure is a collection of sql statemtns
create procedure sp_sum(@a int,@b int)
as
begin
begin try
declare @result int
set @result=@a+@b
select @result
end try
begin catch
select 'Error Occured'
select ERROR_MESSAGE()
end catch
end
Go
--execute stored procedure
exec sp_sum 23,34
exec sp_sum @b=43,@a=23