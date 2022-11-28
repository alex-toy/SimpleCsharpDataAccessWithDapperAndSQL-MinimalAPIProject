CREATE PROCEDURE [dbo].[spUser_GetAll]
	@param1 int = 0,
	@param2 int
AS
BEGIN
	SELECT * FROM dbo.[User];
END
