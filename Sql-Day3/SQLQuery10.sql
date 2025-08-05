create table Student
(
   sno int constraint pk_student_sno primary key, 
   nam varchar(30),
   sub1 int, sub2 int,sub3 int,
   tot int,aveg float,InsertedOn DateTime,
   InsertedBy varchar(100)
)
GO

Create Trigger trgStudentInsert ON Student FOR INSERT
AS
BEGIN
	Declare
		@sno INT
	select @sno = sno from inserted
	Update Student Set tot = sub1 + sub2 + sub3, aveg = (sub1 + sub2 + sub3) /3, 
		InsertedOn = GETDATE(), InsertedBy = SYSTEM_USER WHERE SNo = @sno
END
GO


Insert INTO Student(Sno,Nam,Sub1,Sub2,sub3) Values(1,'Venkata',87,74,91) 
GO

Insert into Student(Sno,Nam,Sub1,SUb2,Sub3) values(2,'Rajesh',87,82,91) 
GO

Insert into Student(sno,nam,sub1,sub2,sub3) values(3,'Uday',88,77,82) 
GO


select * from Student 
GO