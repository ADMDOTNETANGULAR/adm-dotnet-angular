select * from sales.customers where state='CA' and city='Campbell'
select * from Person
sp_helpindex Person
create unique clustered index index_id on Person(Id)
create nonclustered index index_Name on Person(Name)
create nonclustered index index_Dob on Person(Dob)