CREATE TABLE [dbo].[Table]
(
	[CustumerID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Adress] NVARCHAR(50) NULL, 
    [City] NVARCHAR(50) NULL, 
    [State] NVARCHAR(20) NULL, 
    [Zip] NCHAR(10) NULL, 
    [Email] NVARCHAR(100) NULL, 
    [CreditLimit] SMALLMONEY NOT NULL IDENTITY, 
    [CustumerSince] SMALLDATETIME NOT NULL
)
