CREATE PROCEDURE [dbo].[Article_Get]
	@Id int = 0
AS
BEGIN
	SELECT * FROM dbo.[Article] WHERE Id = @Id
END
