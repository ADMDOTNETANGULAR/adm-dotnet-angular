declare @a varchar(30)
declare sample_cursor cursor 
read_only for
select empid from employee
open sample_cursor
fetch next from sample_cursor into @a
while @@FETCH_STATUS<>-1
begin
print @a
fetch next from sample_cursor into @a
end
close sample_cursor
deallocate sample_cursor 