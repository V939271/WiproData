CREATE TABLE [dbo].[Employee](
	[EmpId] [int] NOT NULL,
	[EmployName] [varchar](30) NULL,
	[MgrId] [int] NULL,
	[LeaveAvail] [int] NULL,
	[DateOfBirth] [datetime] NULL,
	[Email] [varchar](30) NULL,
	[Mobile] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Employee] ([EmpId], [EmployName], [MgrId], [LeaveAvail], [DateOfBirth], [Email], [Mobile]) VALUES (1000, N'Muskan', NULL, 20, CAST(N'2002-12-12T00:00:00.000' AS DateTime), N'muskan@gmail.com', N'992445552')
INSERT [dbo].[Employee] ([EmpId], [EmployName], [MgrId], [LeaveAvail], [DateOfBirth], [Email], [Mobile]) VALUES (2000, N'Aadithian', 1000, 22, CAST(N'2002-05-12T00:00:00.000' AS DateTime), N'aadi@gmail.com', N'99293444')
INSERT [dbo].[Employee] ([EmpId], [EmployName], [MgrId], [LeaveAvail], [DateOfBirth], [Email], [Mobile]) VALUES (3000, N'Avinash', 1000, 28, CAST(N'2001-11-11T00:00:00.000' AS DateTime), N'Avin@gmail.com', N'9922445')
INSERT [dbo].[Employee] ([EmpId], [EmployName], [MgrId], [LeaveAvail], [DateOfBirth], [Email], [Mobile]) VALUES (4000, N'Prashanth', 2000, 18, CAST(N'2002-11-12T00:00:00.000' AS DateTime), N'prash@gmail.com', N'99234544')
INSERT [dbo].[Employee] ([EmpId], [EmployName], [MgrId], [LeaveAvail], [DateOfBirth], [Email], [Mobile]) VALUES (5000, N'Anjali', 3000, 18, CAST(N'2002-12-12T00:00:00.000' AS DateTime), N'anjali@gmail.com', N'9994222')
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([MgrId])
REFERENCES [dbo].[Employee] ([EmpId])
GO


select Employ.Empno, Name, Dept, Basic, 
LeaveHistory.LeaveId, LeaveStartDate, LeaveEndDate
from Employ INNER JOIN LeaveHistory 
ON Employ.Empno = LeaveHistory.EmpNo;

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E INNER JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo;

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A INNER JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
INNER JOIN Policy P ON P.PolicyId = AP.PolicyID;

-- Example for Left-Outer Join 


select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E LEFT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo;

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A LEFT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
LEFT JOIN Policy P ON P.PolicyId = AP.PolicyID;

-- Example for Right-Outer Join

select E.Empno, Name, Dept, Basic, 
LH.LeaveId, LeaveStartDate, LeaveEndDate
from Employ E RIGHT JOIN LeaveHistory LH 
ON E.Empno = Lh.EmpNo;

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A RIGHT JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
RIGHT JOIN Policy P ON P.PolicyId = AP.PolicyID;

-- Example for Full outer Join

select A.AgentId, FirstName, LastName, City, State,
P.PolicyId, AppNumber, ModalPremium, AnnualPremium, PaymentModeId
from Agent A FULL JOIN AgentPolicy AP ON 
A.AgentId = AP.AgentID 
FULL JOIN Policy P ON P.PolicyId = AP.PolicyID;


-- Cross Join 

select * from Agent cross join AgentPolicy;

select * from Policy Cross Join AgentPolicy;



SELECT TOP (1000) [EmpId]
      ,[EmployName]
      ,[MgrId]
      ,[LeaveAvail]
      ,[DateOfBirth]
      ,[Email]
      ,[Mobile]
  FROM [wiprojuly].[dbo].[Employee]


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 INNER JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO


select E1.EmpId 'Manager Id',E1.EmployName 'Manager Name',
E2.EmpId 'Employee Id',E2.EmployName 'Employee Name'
from Employee E1 RIGHT JOIN Employee E2 ON 
E1.EmpId = E2.MgrId
GO


SELECT TOP (1000) [Empno]
      ,[Name]
      ,[Gender]
      ,[Dept]
      ,[Desig]
      ,[Basic]
  FROM [wiprojuly].[dbo].[Employ]

  select max(basic) from Employ;

  select name from Employ where basic = (select max(basic) from Employ) 
  GO

  -- Dispaly second max. salary 

  select max(basic) from Employ where basic < 
  (select Max(basic) from Employ)

  -- Display Name of employ who is getting 2nd max. salary

  select Name from Employ where basic = (
    select max(basic) from Employ where basic < 
  (select Max(basic) from Employ))
  GO

  select * from Policy;


  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  ROW_NUMBER() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select PolicyId, AppNumber, ModalPremium, AnnualPremium,
  DENSE_RANK() OVER(Order By AnnualPremium desc) 'Rno'
  from Policy
  GO

  select * from Policy
  GO

  select max(annualpremium) from Policy 
  GO

  -- Display PolicyID of max. annualpremium 

  select PolicyId from Policy WHERE AnnualPremium = 
  (select MAX(annualpremium) from  Policy)

  -- Display 2nd max AnnualPremium 

  select max(annualpremium) from Policy WHERE AnnualPremium < 
  (select max(annualpremium) from Policy)


  --/*----------------------*/

  -- Display matching records from Employ and LeaveHistory table 

select * from Employ where Empno = ANY(select Empno from LeaveHistory)
GO

-- Display matching records from Agent and AgentPolicy Tables 

select * from Agent WHERE AgentId = ANY(select AgentId from AgentPolicy) 

-- Display Matching records from Policy and AgentPolicy Tables 

select * from Policy WHERE PolicyId = ANY (select PolicyId from AgentPolicy) 
GO

-- Display Employ Details who are not taken Leave (Means records which are in Employ table, but not in
-- LeaveHistory Table)

select * from Employ WHERE Empno <> ALL(select Empno from LeaveHistory) 
GO

-- Display Idle Agents (AgentId Exists in Agent Table, but not in AgentPolicy Table) 

select * from Agent where AgentId <> ALL(select AgentId from AgentPolicy) 
GO

-- Display Idle Policies (PolicyId exists in Policy Table, but not in AgentPolicy Table) 

select * from Policy WHERE PolicyId <> ALL(select PolicyId from AgentPolicy) 
GO



create table EmployDummy
(
   eno int,
   name int,
   basic int
)

-- Add primary key on Eno field 


alter table EmployDummy alter column eno int not null;

alter table EmployDummy add primary key(eno);

-- Change name field to varchar(30) 

alter table EmployDummy alter column name varchar(30) 

-- Change basic field to numeric(9,2) 

alter table EmployDummy Alter Column Basic Numeric(9,2);

sp_help EmployDummy
GO

alter table EmployDummy Add Gender varchar(10)


-- Drop Gender column from EmployDummy table 

alter table EmployDummy drop column Gender 
GO

----------****______________________

if exists(select * from sysobjects where name='prcEmployInsert') 
Drop Proc PrcEmployInsert 
GO

Create Proc PrcEmployInsert
				@Name varchar(30),
				@gender varchar(10),
				@dept varchar(30),
				@desig varchar(30),
				@basic Numeric(9,2)
AS
BEGIN
	Declare
		@empno INT 
	begin
		select @empno= case when max(empno) is NULL THEN 1 else 
			max(empno)+1 END from Employ
		Insert into Employ(empno,Name,Gender,Dept,Desig,Basic) 
			values(@empno,@name,@gender,@dept,@desig,@basic) 
		Print 'Employ Record Inserted...'
	end
END
GO
Exec PrcEmployInsert 'Madhu','Male','Dotnet','Expert',88323 
GO



----------------------------***********************____________________________


if exists(select * from sysobjects where name='prcEmployOut') 
Drop Proc prcEmployOut
GO

Create proc prcEmployOut
				@empno INT,
				@name varchar(30) OUTPUT,
				@gender varchar(30) OUTPUT,
				@dept varchar(30) OUTPUT,
				@desig varchar(30) OUTPUT,
				@basic numeric(9,2) OUTPUT
AS
BEGIN
	if exists(select * from Employ where empno = @empno) 
	BEGIN
		select @name=name, @gender = Gender, @dept = Dept,
				@desig = Desig, @basic = Basic 
		from Employ WHERE Empno = @empno
		RETURN 1
	END
	RETURN 0
END

if exists(select * from sysobjects where name='prcEmployOutExec') 
Drop Proc prcEmployOutExec
GO

Create Proc prcEmployOutExec
					@empno INT
AS
BEGIN
	declare 
		@ret INT,
		@name varchar(30),
		@gender varchar(10),
		@dept varchar(30),
		@desig varchar(30),
		@basic numeric(9,2)
		Exec @ret = prcEmployOut @empno, @name OUTPUT, @Gender OUTPUT, @Dept OUTPUT, @Desig OUTPUT,
				@BAsic OUTPUT 
		if @ret = 1
		BEGIN
			print 'Name ' +@name 
			Print 'Gender ' +@gender
			Print 'Department ' +@dept
			Print 'Designation ' +@desig 
			Print 'Basic ' +convert(varchar,@basic)
		END
		ELSE 
		BEGIN
			Print 'Employ Record Not Found...'
		END
END
GO
Exec prcEmployOutExec 1 
GO



----------------*********************-------------------

if exists(select * from sysobjects where name='prcEmployAutoGen') 
Drop Proc prcEmployAutoGen
GO

create  procedure prcEmployAutoGen
			@empno INT OUTPUT
AS
BEGIN
	select @empno = 
		case when max(empno) IS NULL THEN 1 else max(empno)+1 END from Employ 

END
GO

if exists(select * from sysobjects where name='PrcEmployInsert') 
Drop Proc PrcEmployInsert
GO

Create proc PrcEmployInsert
			@name varchar(30),
			@gender varchar(10),
			@dept varchar(30),
			@desig varchar(30),
			@basic numeric(9,2)
AS
BEGIN
	Declare
		@empno INT 
	BEGIN
		Exec prcEmployAutoGen @empno OUTPUT 
		Insert into Employ(Empno,Name,Gender,Dept,Desig,Basic) values(@empno,@name,@gender,
				@dept,@desig,@basic)
		Print 'Employ Record Inserted...'
	END
END
GO

Exec PrcEmployInsert 'Vasim','MALE','Dotnet','Manager',88233 
GO

select * from Employ 
GO