using DataAccess.Models;
using DataAccess.Repositories;

namespace DataAccess.Data.Articles;

public class ArticleData : IArticleData
{
	private readonly ISqlDataAccess _db;

	public ArticleData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<Article>> GetAll() => _db.LoadData<Article, dynamic>("Article_GetAll", new { });

	public async Task<Article> Get(int id)
	{
		var results = await _db.LoadData<Article, dynamic>("Article_Get", new { Id = id });
		return results.FirstOrDefault();
	}

	public Task Insert(Article Article) => _db.SaveData("Article_Insert", MapArticle(Article));

	public Task Update(Article Article) => _db.SaveData("Article_Update", Article);

	public Task Delete(int id) => _db.SaveData("Article_Delete", new { Id = id });

	private object MapArticle(Article article) => new { article.Name, article.Description, article.Price };
}
