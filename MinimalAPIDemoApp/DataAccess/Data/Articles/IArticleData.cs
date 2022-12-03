using DataAccess.Models;

namespace DataAccess.Data.Articles;

public interface IArticleData
{
	Task Delete(int id);
	Task<Article> Get(int id);
	Task<IEnumerable<Article>> GetAll();
	Task Insert(Article Article);
	Task Update(Article Article);
}