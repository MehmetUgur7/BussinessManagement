CREATE TABLE [dbo].[Assignments]
(
	[AssignmentId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Date] DATE NULL, 
    [RegionId] INT NULL, 
    [VehicleId] INT NULL, 
    [DriverId] INT NULL, 
    [PassengerId] INT NULL, 
    [VehicleStartKm] INT NULL, 
    [VehicleReturnKm] INT NULL, 
    CONSTRAINT [FK_Assignments_Regions] FOREIGN KEY ([RegionId]) REFERENCES [Regions]([RegionId]), 
    CONSTRAINT [FK_Assignments_Vehicles] FOREIGN KEY ([VehicleId]) REFERENCES [Vehicles]([VehicleId]), 
    CONSTRAINT [FK_Assignments_Persons] FOREIGN KEY ([DriverId]) REFERENCES [Persons]([PersonId]),

)
