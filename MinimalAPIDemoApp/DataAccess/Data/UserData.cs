using DataAccess.Models;
using DataAccess.Repositories;

namespace DataAccess.Data;

public class UserData : IUserData
{
	private readonly ISqlDataAccess _db;

	public UserData(ISqlDataAccess db)
	{
		_db = db;
	}

	public Task<IEnumerable<User>> GetAll() =>
		_db.LoadData<User, dynamic>("spUser_GetAll", new { });

	public async Task<User> Get(int id)
	{
		var results = await _db.LoadData<User, dynamic>("spUser_Get", new { Id = id });
		return results.FirstOrDefault();
	}

	public Task Insert(User user) => _db.SaveData("spUser_Insert", MapUser(user));

	public Task Update(User user) => _db.SaveData("spUser_Update", user);

	public Task Delete(int id) => _db.SaveData("spUser_Delete", new { Id = id });

	private object MapUser(User user) => new { user.FirstName, user.LastName };
}
