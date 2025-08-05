Create Proc PrcEmpMult
				@eno INT,
				@nam varchar(30),
				@gen varchar(30),
				@bas numeric(9,2)
AS
BEGIN
	  Declare 
		@erNo INT
		BEGIN TRAN T1
		BEGIN TRY
		Insert into EmployPrc values(@eno,@nam,@gen,@bas)
		Update EmployPrc set Salary = Salary + 10000 where eno = @eno 
		PRint @@TranCount
		if @@TRANCOUNT > 2
		BEGIN
			Print 'Both Transactions are committed...'
			Commit Tran T1
		END
	END TRY
	BEGIN CATCH
		PRINT @@TRANCOUNT 
	    if @@TRANCOUNT >= 1 
		BEGIN
			Print 'No Operation Committed...'
			Rollback Tran T1
		END
		
	END CATCH
END
GO

Exec PrcEmpMult 2911,'Venkata','MALE',78822
GO