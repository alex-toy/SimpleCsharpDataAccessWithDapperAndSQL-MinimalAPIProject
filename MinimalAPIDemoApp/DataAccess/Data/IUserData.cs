using DataAccess.Models;

namespace DataAccess.Data;

public interface IUserData
{
	Task Delete(int id);
	Task<User> Get(int id);
	Task<IEnumerable<User>> GetAll();
	Task Insert(User user);
	Task Update(User user);
}