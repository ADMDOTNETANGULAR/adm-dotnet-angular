--create function
create function fn_sum(@a int,@b int)
returns int
as
begin
declare @sum int
set @sum=@a+@b
return @sum
end
Go
print dbo.fn_sum(2,3)
select dbo.fn_sum(34,44)