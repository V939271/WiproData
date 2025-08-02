



create database wiprojuly
go

use wiprojuly
go

If Exists(select * from sysobjects where name='LeaveHistory') 
Drop Table LeaveHistory 
GO

if exists(select * from sysobjects where name='Employ') 
Drop Table Employ 
GO

Create Table Employ
(
	Empno INT constraint pk_employ_empno primary key,
	Name varchar(30) NOT NULL,
	Gender varchar(10) 
	Constraint chk_employ_gender CHECK(Gender IN('MALE','FEMALE')), 
	Dept varchar(30) 
	Constraint chk_employ_dept CHECK(Dept IN('Dotnet','Java','Python')),
	Desig varchar(30) NOT NULL,
	Basic Numeric(9,2) constraint chk_employ_basic CHECK(Basic Between 10000 and 90000)
)
GO

Insert into Employ(Empno,Name,Gender,Dept,Desig,Basic) 
values(1,'Yamini','FEMALE','Dotnet','Expert',88222),
(2,'Anusha','FEMALE','Java','Manager',82222),
(3,'Uday','MALE','Python','Expert',68833),
(4,'Datta','MALE','Dotnet','Manager',88322),
(5,'Mahi','FEMALE','Python','Expert',88223)
GO

Create Table LeaveHistory
(
    LeaveId INT IDENTITY(1,1) Constraint pk_leaveHistory_leaveId Primary Key,
	EmpNo INT Constraint FK_Employ_Empno FOREIGN KEY(Empno) REFERENCES Employ(Empno),
	LeaveStartDate Date,
	LeaveEndDate Date,
	noOfDays INT,
	LossOfPay numeric(9,2)
)
GO

Insert into LeaveHistory(EmpNo, LeaveStartDate, LeaveEndDate) 
Values(1,'08/02/2025','08/05/2025'),
      (2,'09/03/2025','09/22/2025')
GO


