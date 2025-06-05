--create variable
declare @id int
declare @product varchar(10)
declare @dob date
--set value to variable
set @id=430834
set @product='Bottle'
set @dob='2.23.2000'
--assing multiple variable values
select @id=3093,@product='key chain',@dob='2019.2.23'
print @id
print @product
print @dob
Go