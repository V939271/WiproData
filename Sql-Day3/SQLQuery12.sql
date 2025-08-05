create table DummyEx
(
   Eno INT,
   Name varchar(30),
   Sal Numeric(9,2)
)
GO

Insert into DummyEx(Eno,Name,Sal) 
		values(12,'Vomesh',82245),
				(7,'Uday',82111),
			(3,'Charishma',81144),
			(18,'Pallavi',81455),
			(15,'Nitin',88155) 
	GO

select * from DummyEx 
GO

Create Clustered Index Idx_Empno 
	ON DummyEx(Eno)
GO


create nonclustered index idx_policy on 
AgentPolicy(AgentID)
GO

Create Nonclustered index idx_agent on
AgentPolicy(PolicyID) 
GO