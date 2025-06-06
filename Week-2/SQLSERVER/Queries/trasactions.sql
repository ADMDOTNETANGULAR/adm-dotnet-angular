--create table accounts(acno int primary key,bal money)

--insert accounts values(100,50000)
--insert accounts values(200,60000)
alter procedure transferamount(
@acno1 int,@acno2 int,@amount money)
as
begin
begin try
begin transaction
update accounts set bal=bal-@amount where acno=@acno1
update accounts set bal=bal+@amount where acno=@acno2
--verify balance of acno1
if((select bal from accounts where acno=@acno1)<5000)
begin
print 'Transaction Failed'
rollback transaction
end
else
begin 
print 'Transaction Successfull'
commit transaction

end
end try
begin catch
print 'something went wrong'
rollback transaction
end catch
end
exec transferamount 100,200,5000
select * from accounts
exec transferamount 100,200,50000