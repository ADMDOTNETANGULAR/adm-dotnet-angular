create trigger tg2
on Employee
after Delete
as
print 'Access denied'
rollback transaction
Go
delete from Employee where EmployeeId='E897'