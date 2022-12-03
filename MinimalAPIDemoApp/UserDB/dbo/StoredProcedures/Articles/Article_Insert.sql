CREATE PROCEDURE [dbo].[Article_Insert]
	@Name nvarchar(10),
	@Description nvarchar(50),
	@Price FLOAT
AS
BEGIN
	INSERT INTO dbo.[Article] VALUES (@Name, @Description, @Price);
END
