CREATE PROCEDURE [dbo].[Article_Delete]
	@Id int = 0
AS
BEGIN
	DELETE FROM dbo.[Article] WHERE Id = @Id;
END
