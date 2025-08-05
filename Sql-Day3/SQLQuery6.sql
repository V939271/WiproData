create proc prcShowPaySlip
					@empno INT
AS
BEGIN
	declare
		@name varchar(30),
		@sal numeric(9,2),
		@tax numeric(9,2),
		@takehome numeric(9,2)
	BEGIN
	if exists(select * from Employ where empno = @empno)
	BEGIN
		select @name=name, @sal = Basic, @tax = dbo.Fncommission(basic),
			@takehome = Basic - dbo.Fncommission(basic)
			from Employ WHERE Empno =@empno
		Print 'Hi Mr/Miss/Mrs' +@name
		Print 'Your Salary is ' +convert(varchar,@sal) 
		Print 'Your Tax to be Paid ' +convert(varchar,@tax) 
		Print 'Your Takhome is ' +convert(varchar,@takehome)
	END
	ELSE
	BEGIN
		Print 'Employ Record Not Found...'
	END
	END
END
GO

EXEC prcShowPaySlip 2

GO