create table EmployPrc (Eno int primary key, Name varchar(30),
Gender varchar(10) check(gender in('Male','Female')),
salary numeric(9,2) check(salary between  10000 and 80000));


CREATE PROCEDURE PreEmpInsNew
    @eno INT,
    @name VARCHAR(30),
    @gen VARCHAR(30),
    @bas NUMERIC(9,2)
AS
BEGIN
    DECLARE @erNo INT

    BEGIN TRY
        INSERT INTO EmployPrc VALUES(@eno, @name, @gen, @bas)
    END TRY
    BEGIN CATCH
        SELECT @erNo = ERROR_NUMBER()
        PRINT 'Error Number: ' + CONVERT(VARCHAR, @erNo)
        PRINT ERROR_MESSAGE()
        PRINT 'Severity: ' + CONVERT(VARCHAR, ERROR_SEVERITY())
        PRINT 'Error Line: ' + CONVERT(VARCHAR, ERROR_LINE())
    END CATCH
END
;


EXEC PreEmpInsNew 101, 'John', 'Male', 25000.50


Exec PreEmpInsNew 3,'Venkata','MALE',90000 ;