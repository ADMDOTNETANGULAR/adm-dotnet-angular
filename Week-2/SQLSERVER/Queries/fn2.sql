create function fn_findAge(@dob date)
returns int
as
begin
declare @age int
set @age=DATEDIFF(yy,@dob,getdate())
return @age
end
GO
select dbo.fn_findAge('2.21.2000') as Age