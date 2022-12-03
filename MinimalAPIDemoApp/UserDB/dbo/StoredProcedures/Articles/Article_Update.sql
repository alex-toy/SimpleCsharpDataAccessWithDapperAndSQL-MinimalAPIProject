CREATE PROCEDURE [dbo].[Article_Update]
	@Id int = 0,
	@name nvarchar(20),
	@description nvarchar(50),
	@price FLOAT
AS
BEGIN
	UPDATE dbo.[Article]
	SET Name = @name, Description = @description, Price = @price
	WHERE Id = @Id;
END
