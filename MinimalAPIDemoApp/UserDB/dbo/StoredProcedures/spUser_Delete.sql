CREATE PROCEDURE [dbo].[spUser_Delete]
	@Id int = 0
AS
BEGIN
	DELETE FROM dbo.[User] WHERE Id = @Id;
END
