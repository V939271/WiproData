create proc prcPolicyInfo
				@policyId INT
AS
BEGIN
	Declare
		@appNumber varchar(30),
		@annualPremium numeric(9,2),
		@paymode varchar(30) 
	BEGIN
		if exists(select * from Policy WHERE PolicyId = @policyId)
		BEGIN
		select	@appNumber = AppNumber, @annualPremium = AnnualPremium, 
			@paymode = dbo.fnPaymode(paymentModeId)
			from Policy WHERE PolicyId = @policyId
		Print 'Application Number ' +@appNumber 
		Print 'AnnualPremium ' +convert(varchar,@annualpremium)
		Print 'Paymode ' +@paymode
		END
		ELSE
		BEGIN
			Print 'Policy Id Not Found...'
		END
	END
END

Exec prcPolicyInfo 2 
GO