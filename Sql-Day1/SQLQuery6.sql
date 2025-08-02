use sqlpractice ;
select * from INFORMATION_SCHEMA.TABLES;

sp_help Emp;

select * from Emp ;

select Empno as "Employ-NO", nam "Employ-Name",basic "Salary" from Emp;

select * from Emp WHERE basic > 50000;

select * from Emp where Dept='Dotnet';

select * from EMP WHERE Basic Between 50000 and 90000;

select * from EMP WHERE Basic NOT Between 50000 and 90000;

select * from Emp where dept in('Dotnet','Java','sql');

select * from Emp where dept not in('Dotnet','Java','sql');

select * from Emp where nam IN('Manu','Satish','Swapna','Smitha','Rushi')

select * from emp where nam like 'S%';

select distinct Dept from Emp ;

select * from Emp order by nam ;

select * from Emp order by Basic DESC;

select * from Emp order by Dept, Nam ;

select * from Emp order by Dept, Nam DESC;

select Abs(-12);

select POWER(2,3) ;


select SQRT(49) ;

select CEILING(12.00000001);

select FLOOR(12.999999);

select CHARINDEX('l','hello') ;

select nam, CHARINDEX('a',nam) from Emp;

select nam, REVERSE(nam) as Reversename from Emp;

select len('Charishma Gada');

select nam, len(nam) from Emp;

select left('Prasanna',4) ;

select right('Prasanna',4);

select nam, upper(nam) from Emp;

select SUBSTRING('welcome to sql',5,8) ;

SELECT REPLACE('Dotnet Training','Dotnet','Java') ;

select GETDATE() ;

select convert(varchar,GetDate(),1);

select convert(varchar,GETDATE(),2) ;

select convert(varchar,GETDATE(),101) ;

select convert(varchar,GETDATE(),103) ;

select datepart(dd,getdate());
select datepart(mm,getdate());
select datepart(yy,getdate());
select datepart(hh,getdate());
select datepart(mi,getdate());
select datepart(ss,getdate());
select datepart(ms,getdate());
select datepart(dw,getdate());
select datepart(qq,getdate());

select datename(dw,getdate());

select convert(varchar,DATEPART(dd,getdate())) + '/' + 
convert(varchar,datepart(mm,getdate())) + '/' + 
convert(varchar,DATEPART(yy,getdate()));

select DATENAME(mm, getdate());

select DATEADD(dd,3,getdate());

select dateadd(mm,3,getdate());

select DATEADD(yy,3,getdate());

select DATEDIFF(dd,'03/09/1980',getdate());
select DATEDIFF(yy,'03/09/1980',getdate());

select sum(basic) from Emp ;

select avg(basic) from Emp ;

select max(basic) from Emp ;

select min(basic) from Emp ;

select count(*) from Emp ;

select count(basic) from Emp;


select * from Agent;

select AgentID, FirstName, LastName, City,MaritalStatus
from Agent ;

-- Write a query ensure, if MaritalStatus is 0 THEN 'Unmarried' if MartialStatus is '1' then Married 

select AgentID, FirstName, LastName, City,MaritalStatus,
case MaritalStatus 
when 0 then 'Unmarried'
when 1 then 'Married'
End 'Marital status'
from Agent;


select * from Policy;

select PolicyID, AppNumber, PolicyNumber, AnnualPremium, PayMentModelID,
CASE PayMentModelID
	WHEN 1 THEN 'Yearly'
	WHEN 2 THEN 'Half-Yearly'
	WHEN 3 THEN 'Quarterly'
END 'PayMode'
from Policy;