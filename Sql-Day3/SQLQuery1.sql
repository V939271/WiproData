create proc proDivision
       @a int,
	   @b int
as 
begin
		begin try
				set @a = 5;
				set @b = @a /0
				print @b
		end try
		begin catch
				print 'Error is'
				print Error_Message()
		end catch
end
;

proDivision 12,0 
;


CREATE PROCEDURE spEvenCheck
    @n INT
AS
BEGIN
    BEGIN TRY
        IF (@n % 2 = 0)
        BEGIN
            PRINT 'No Error'
            PRINT 'Even Number'
        END
        ELSE
        BEGIN
            PRINT 'Error occurred'
            RAISERROR('Error occurred', 16, 1);
        END
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE()
    END CATCH
END;


spEvenCheck 6;

