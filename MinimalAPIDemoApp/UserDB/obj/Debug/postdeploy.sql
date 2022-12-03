/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF NOT EXISTS (SELECT 1 FROM dbo.[User]) BEGIN
    INSERT INTO dbo.[User] (FirstName, LastName)
    VALUES 
        ('alexei', 'reaktor'),
        ('shirley', 'pepette'),
        ('william', 'amin');
END

IF NOT EXISTS (SELECT 1 FROM dbo.[Article]) BEGIN
    INSERT INTO dbo.[Article] (Name, Description, Price)
    VALUES 
        ('pants', 'pretty', 12),
        ('shirt', 'nice', 14);
END
GO
