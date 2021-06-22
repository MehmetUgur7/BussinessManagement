CREATE TABLE [dbo].[Positions]
(
	[PositionId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PositionName] VARCHAR(50) NULL, 
    [PositionPaymentAmount] MONEY NULL
)
