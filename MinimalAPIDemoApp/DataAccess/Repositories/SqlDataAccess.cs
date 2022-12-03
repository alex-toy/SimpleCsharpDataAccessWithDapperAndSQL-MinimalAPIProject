using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositories;

public class SqlDataAccess : ISqlDataAccess
{
	private readonly IConfiguration _config;

	public SqlDataAccess(IConfiguration config)
	{
		this._config = config;
	}

	public async Task<IEnumerable<T>> LoadData<T, U>(
		string storedProcedure,
		U parameters,
		string connectionId = "Default"
		)
	{
		string connectionString = _config.GetConnectionString(connectionId);
		//The using keyword makes so that at the end of the method, the connection is properly closed
		using IDbConnection connection = new SqlConnection(connectionString);
		return await connection.QueryAsync<T>(
			storedProcedure,
			parameters,
			commandType: CommandType.StoredProcedure
		);
	}

	public async Task SaveData<T>(
		string storedProcedure,
		T parameters,
		string connectionId = "Default"
		)
	{
		string connectionString = _config.GetConnectionString(connectionId);
		//The using keyword makes so that at the end of the method, the connection is properly closed
		using IDbConnection connection = new SqlConnection(connectionString);

		await connection.ExecuteAsync(
			storedProcedure,
			parameters,
			commandType: CommandType.StoredProcedure
		);
	}
}
