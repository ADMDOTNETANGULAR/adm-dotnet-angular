declare @name varchar(10)
set @name='Virat'
declare @count int
set @count=1
while @count<=10
begin
print 'Hello '+@name
set @count=@count+1
end