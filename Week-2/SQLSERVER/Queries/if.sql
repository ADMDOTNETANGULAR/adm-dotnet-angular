declare @a int
declare @b int
select @a=3433,@b=443
if @a>@b
begin
print cast(@a as varchar(10)) +' is bigger'
print 'Good Morning'
end
else
print convert(varchar(10),@b) + ' is bigger'
Go
