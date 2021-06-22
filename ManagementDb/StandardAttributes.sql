CREATE TABLE [dbo].[StandardAttributes]
(
	[StandardAttributeId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [StandardId] INT NULL, 
    [StandardName] VARCHAR(500) NULL, 
    [PersonId] INT NULL, 
    CONSTRAINT [FK_StandardAttributes_Standards] FOREIGN KEY ([StandardId]) REFERENCES [Standards]([StandardId])
)
