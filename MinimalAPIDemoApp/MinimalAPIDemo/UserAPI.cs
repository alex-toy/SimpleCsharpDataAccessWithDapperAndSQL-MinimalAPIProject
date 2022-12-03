namespace MinimalAPIDemo;

public static class UserAPI
{
	public static void ConfigureUserAPI(this WebApplication app)
	{
		app.MapGet("/users", GetUsers);
		app.MapGet("/user/{id}", GetUser);
		app.MapPost("/users", InsertUser);
		app.MapPut("/users", UpdateUser);
		app.MapDelete("/users", DeleteUser);
	}

	private static async Task<IResult> GetUsers(IUserData user)
	{
		try
		{
			return Results.Ok(await user.GetAll());
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> GetUser(int id, IUserData user)
	{
		try
		{
			IResult? results = Results.Ok(await user.Get(id));
			if (results == null) return Results.NotFound();
			return Results.Ok(results);
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> InsertUser(User user, IUserData userData)
	{
		try
		{
			await userData.Insert(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> UpdateUser(User user, IUserData userData)
	{
		try
		{
			await userData.Update(user);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> DeleteUser(int id, IUserData userData)
	{
		try
		{
			await userData.Delete(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
}
