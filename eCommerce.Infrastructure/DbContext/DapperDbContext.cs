using System.Data;
using Npgsql;
using Microsoft.Extensions.Configuration;

public class DapperDbContext
{
    private readonly IConfiguration _configuration;
    private readonly string? _connectionString;

    public DapperDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        _connectionString = _configuration.GetConnectionString("PostgresConnection");
    }

    // Expose a DbConnection property
    public IDbConnection DbConnection => new NpgsqlConnection(_connectionString);
}
