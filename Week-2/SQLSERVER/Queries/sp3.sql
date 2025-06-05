alter procedure sp_square(@n varchar(20))
as
begin
begin try
declare @result int
set @result=cast(@n as int)*cast(@n as int)
return @result
end try
begin catch
select ERROR_MESSAGE() as Message
select ERROR_PROCEDURE() as ProcedureName
select ERROR_NUMBER() as ErrorNumber
select ERROR_LINE() as ErrorLine
end catch
end
Go

declare @result int
exec @result=sp_square 'abc'
print @result