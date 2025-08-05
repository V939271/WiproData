create function fnEvenOdd(@n INT) RETURNS varchar(30)
AS
BEGIN
	if (@n%2=0)
	BEGIN
		RETURN 'Even Number'
	END
	ELSE
	BEGIN
		RETURN 'Odd Number'
	END
	RETURN ''
END
GO

select dbo.fnEvenOdd(4)
GO

select * from Employ 
GO

Create Function Fncommission(@sal INT) RETURNS Numeric(9,2)
AS
BEGIN
	RETURN @Sal * 0.03
END
GO

select dbo.Fncommission(10000);

select Empno, Name, Gender, Dept, Basic, dbo.Fncommission(Basic) 'Commission',
			Basic - dbo.Fncommission(Basic) 'Take Home'
from Employ
GO

select * from Agent
GO

create function fnAgentMStat(@maritalStatus INT) RETURNS Varchar(30)
AS
BEGIN
	declare
		@res varchar(30)
	if @maritalStatus = 0
	BEGIN
		set @res = 'Unmarried'
	end  
	if @maritalStatus = 1 
	BEGIN
		set @res = 'Married'
	END
	return @res 
END
GO

select dbo.fnAgentMStat(0)

select AgentId, FirstName, LastName, City, MaritalStatus, dbo.fnAgentMStat(MaritalStatus)
from Agent 
GO

select * from Policy
GO


Create Function fnPaymode(@paymode INT) RETURNS varchar(30)
AS
BEGIN
	declare
		@res varchar(30)
	if @paymode = 1 
	BEGIN
		set @res='Yearly'
	END
	if @paymode = 2
	BEGIN
		set @res = 'Half-Yearly'
	END
	if @paymode = 3
	BEGIN
		set @res =  'Quarterly'
	END
	return @res 
END
GO

select PolicyId, AppNumber, AppDate, PaymentModeId, dbo.fnPaymode(PaymentModeId)
from Policy
GO