--Date functions
select getdate()
select sysdatetime()
select CURRENT_TIMESTAMP
select year('12.2.2010')
select month('12.2.2010')
select day('12.2.2010')
select DATEPART(YY,'12.2.2010') -- get year
select DATEPART(MM,'12.2.2010') --get month
select DATEPART(DD,'12.2.2010') --get date
select DATENAME(weekday,'12.2.2010') --get weekname
select DATENAME(weekday,'8.23.2000')
select DATENAME(weekday,'8.15.1947')
select DATEDIFF(yy,'8.15.1947',getdate())
select DATEDIFF(yy,'8.15.2000',getdate())
select DATEDIFF(MM,'8.15.2000',getdate())
select DATEDIFF(DD,'8.15.2000',getdate())
select DATEADD(DD,5,getdate())
select getdate()
select FORMAT(getdate(),'dd.mm.yy')
select FORMAT(getdate(),'dd.mm.yyyy')