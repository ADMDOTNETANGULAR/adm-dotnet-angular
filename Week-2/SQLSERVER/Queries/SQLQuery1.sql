--create new database
create database ADMDOTNET
--A Database is a collection of objects
--tables,views,stored procedures,functions,triggers,cursors
-- choose database
use ADMDOTNET
--DDL Commands
--Create
--Alter
--Truncate
--Drop
--Create(table,sp,functions,views,indexers)
--Create table
create table Person(Id int,[Name] varchar(20),Dob Date,[Address] char(20))
sp_help Person