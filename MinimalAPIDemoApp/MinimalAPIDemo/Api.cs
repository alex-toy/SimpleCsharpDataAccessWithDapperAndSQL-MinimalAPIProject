namespace MinimalAPIDemo;

public static class Api
{
	public static void ConfigureHTTPRequestPipeline(this WebApplication app)
	{
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();
	}

	public static void ConfigureAPI(this WebApplication app)
	{
		app.ConfigureUserAPI();
		app.ConfigureArticleAPI();
	}
}
