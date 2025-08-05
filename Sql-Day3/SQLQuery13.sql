create view vwEmploy
AS
	select * from Employ 
GO

select * from vwEmploy 
GO

create view vwEmployReport
AS
	select Empno, Name, Gender, Dept, Basic, dbo.Fncommission(Basic) 'Commission',
			Basic - dbo.Fncommission(Basic) 'Take Home' from Employ
GO

select * from vwEmployReport 
GO

create view vwAgentPolicy 
AS
select 
	A.AgentId, FirstName, LastName, City, State,
		P.PolicyId, AppNumber, AppDate, ModalPremium, AnnualPremium
from Agent A INNER JOIN AgentPolicy AP
ON A.AgentId = AP.AgentID 
INNER JOIN Policy P 
ON P.PolicyId = AP.PolicyID
GO

select * from vwAgentPolicy 
GO