--cursor Demo
declare @empid varchar(30)
declare db_cursor cursor for
select empid from employee
open db_cursor
fetch next from db_cursor into @empid 
while @@FETCH_STATUS<>-1
begin
insert into valid_login(Username) values(@empid)
fetch next from db_cursor into @empid
end
close db_cursor
deallocate db_cursor
select * from valid_login 