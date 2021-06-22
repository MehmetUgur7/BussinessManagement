CREATE TABLE [dbo].[Persons]
(
	[PersonId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdentityNumber] VARCHAR(50) NOT NULL, 
    [RegistrationNumber] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [PositionId] INT NULL, 
    [EmailAddress] VARCHAR(100) NULL, 
    [EmergencyContact] VARCHAR(100) NULL, 
    [EmergencyNumber] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Persons_Positions] FOREIGN KEY ([PositionId]) REFERENCES [Positions]([PositionId])
)
