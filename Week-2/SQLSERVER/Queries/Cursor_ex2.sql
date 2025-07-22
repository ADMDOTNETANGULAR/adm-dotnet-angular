select * from emp1
declare @desig varchar(30)
declare @bonous int
declare c1 cursor read_only for
select desig from emp1
open c1
fetch next from c1 into @desig
while @@FETCH_STATUS<>-1
begin
if(@desig='TeamLeader')
begin
set @bonous=5000
update emp1 set sal=sal+@bonous where Desig='TeamLeader'
end
fetch next from c1 into @desig
end
close c1
deallocate c1
