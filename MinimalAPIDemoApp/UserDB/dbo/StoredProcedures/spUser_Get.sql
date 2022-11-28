CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int = 0
AS
BEGIN
	SELECT * FROM dbo.[User] WHERE Id = @Id
END
