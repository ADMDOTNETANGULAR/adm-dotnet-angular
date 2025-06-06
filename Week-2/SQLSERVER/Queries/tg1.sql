--create a trigger
create trigger tg1
on Project
After insert
as
print 'Thanks for Adding new Project'
Go
insert into Project values('P876','Project-Y')