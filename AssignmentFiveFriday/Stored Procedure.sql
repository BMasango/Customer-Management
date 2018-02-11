USE [Workshop]
GO

/****** Object:  StoredProcedure [dbo].[RetrieveCustomerDetails]    Script Date: 2018/02/11 8:58:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RetrieveCustomerDetails]
AS
BEGIN
	SELECT *
	FROM Customer

	SELECT *
	FROM CustomerContacts

	--SELECT c.ID AS CustomerID,cc.ID AS CustomerContactID,c.Name,c.Latitude,c.Longitude,cc.Email,cc.ContactNo
	--FROM Customer AS c 
	--	INNER JOIN CustomerContacts AS cc 
	--	ON c.ID = cc.CustomerID
	--WHERE c.Name = @CustomerName
END
GO


