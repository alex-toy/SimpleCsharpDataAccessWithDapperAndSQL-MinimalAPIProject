CREATE TABLE [dbo].[Article]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
    [Name] NVARCHAR(20) NOT NULL, 
    [Description] NVARCHAR(50) NOT NULL,
    [Price] FLOAT
)
