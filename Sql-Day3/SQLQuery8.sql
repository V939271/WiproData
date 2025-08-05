select * from Employ 
GO

Create Function EmployTabEx() RETURNS @EmployTab TABLE 
(
	Empno INT,Name varchar(30), Basic Numeric(9,2)
)
AS
BEGIN
	Insert into @EmployTab 
		select Empno, Name,Basic from Employ
	RETURN
END
GO

select * from dbo.EmployTabEx();