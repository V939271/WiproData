create Proc PrcEmpRaise
				@eno INT,
				@nam varchar(30),
				@gen varchar(30),
				@bas numeric(9,2)
AS
BEGIN
	  Declare 
		@erNo INT
		BEGIN TRY
		Insert into EmployPrc values(@eno,@nam,@gen,@bas)
	END TRY
	BEGIN CATCH
		RAISERROR('Error Occurred In Constraints please check table Definition',16,3)
	END CATCH
END;

Exec PrcEmpRaise 3,'Venkata','MALE',90000 ;