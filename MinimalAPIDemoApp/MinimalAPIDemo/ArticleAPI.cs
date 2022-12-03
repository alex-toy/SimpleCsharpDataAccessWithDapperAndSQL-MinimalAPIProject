using DataAccess.Data.Articles;

namespace MinimalAPIDemo;

public static class ArticleAPI
{
	public static void ConfigureArticleAPI(this WebApplication app)
	{
		app.MapGet("/articles", GetAll);
		app.MapGet("/articles/{id}", Get);
		app.MapPost("/articles", InsertUser);
		app.MapPut("/articles", UpdateUser);
		app.MapDelete("/articles", DeleteUser);
	}

	private static async Task<IResult> GetAll(IArticleData articleData)
	{
		try
		{
			return Results.Ok(await articleData.GetAll());
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> Get(int id, IArticleData articleData)
	{
		try
		{
			IResult? results = Results.Ok(await articleData.Get(id));
			if (results == null) return Results.NotFound();
			return Results.Ok(results);
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> InsertUser(Article article, IArticleData userData)
	{
		try
		{
			await userData.Insert(article);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> UpdateUser(Article article, IArticleData articleData)
	{
		try
		{
			await articleData.Update(article);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}

	private static async Task<IResult> DeleteUser(int id, IArticleData articleData)
	{
		try
		{
			await articleData.Delete(id);
			return Results.Ok();
		}
		catch (Exception ex)
		{
			return Results.Problem(ex.Message);
		}
	}
}
