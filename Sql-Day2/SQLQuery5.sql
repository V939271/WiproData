if exists(select * from sysobjects where name='PrcSayHello') 
Drop Proc PrcSayHello 
GO
Create proc prcSayHello
AS
BEGIN
	PRINT 'Welcome to T-Sql'
END
GO

Exec prcSayHello
GO


if exists(select * from sysobjects where name='prcEmpSearch') 
Drop Proc PrcEmpSearch 
GO

Create Proc PrcEmpSearch
					@empno INT
AS
BEGIN
	declare 
		@name varchar(30),
		@dept varchar(30),
		@gender varchar(10),
		@desig varchar(30),
		@basic Numeric(9,2)
	BEGIN
	if exists(select * from Employ where empno = @empno) 
	BEGIN
		select @name = Name, @gender = Gender, 
				@dept = Dept, @desig = Desig,
				@Basic= Basic 
		  From Employ WHERE Empno = @empno
		Print 'Employ Name ' +@name 
		Print 'Gender ' +@gender 
		Print 'Department ' +@dept 
		Print 'Designation ' +@desig 
		Print 'Basic ' +convert(varchar,@basic)
	END
	ELSE
	BEGIN
		Print 'Record Not Found...'
	END
	END
END


Exec PrcEmpSearch 1  
GO

-- To display the content of the stored procedure 

sp_helptext PrcEmpSearch 
GO