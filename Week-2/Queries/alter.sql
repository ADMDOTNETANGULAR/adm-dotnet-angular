--Alter table
sp_help person
--add column
alter table Person add State varchar(10),City varchar(20)
--drop column
alter table Person drop column Address
--chage datatype
alter table Person alter column Id varchar(20) not null
--add constraint
alter table Person add constraint pk_id primary key(Id)
--drop constraint
alter table Person drop constraint pk_id