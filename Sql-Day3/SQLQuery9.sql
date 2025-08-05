select * from Employ
GO

select * from LeaveHistory
GO

Create Function FnEmpLeaveHistory() RETURNS @EmpLeave TABLE
(
	Empno INT, Name varchar(30), Basic numeric(9,2), leaveId INT,
		LeaveStartDate Date, LeaveEndDate Date, Lop INT
)
AS
BEGIN
	INSERT INTO @EmpLeave
	select E.Empno, Name, Basic, LeaveId, LeaveStartDate, LeaveEndDate, LossOfPay
	from Employ E INNER JOIN LeaveHistory LH ON E.Empno = LH.EmpNo
	RETURN
END
GO

select * from dbo.FnEmpLeaveHistory()
GO