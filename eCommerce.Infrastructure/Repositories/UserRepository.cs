using Dapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;

namespace eCommerce.Infrastructure.Repositories;
public class UserRepository(DapperDbContext dbContext) : IUserRepository
{
    private readonly DapperDbContext _dbContext = dbContext;
    public async Task<ApplicationUser> AddUser(ApplicationUser user)
    {
        user.UserId = Guid.NewGuid();

        string query = "INSERT INTO public.\"User\" (\"UserId\", \"Email\", \"Password\", \"PersonName\", \"Gender\") VALUES (@UserId, @Email, @Password, @PersonName, @Gender)";
        int rowCountAffected = await _dbContext.DbConnection.ExecuteAsync(query, user);

        if (rowCountAffected > 0)
        {
            return user;
        }
        else
        {
            return null;
        }

    }

    public async Task<ApplicationUser> GetUserByEmailAndPassword(string? email, string? password)
    {
        string query = "SELECT * FROM public.\"User\" WHERE \"Email\" = @Email AND \"Password\" = @Password";
        ApplicationUser? user = await _dbContext.DbConnection.QueryFirstOrDefaultAsync<ApplicationUser>(query, new { Email = email, Password = password });
        return user;
    }

    public async Task<List<ApplicationUser>> GetUsers()
    {
        string query = "SELECT * FROM public.\"User\"";
        IEnumerable<ApplicationUser> users = await _dbContext.DbConnection.QueryAsync<ApplicationUser>(query);
        return users.ToList();
    }

    public Task<bool> IsEmailAlreadyExists(string? email)
    {
        string query = "SELECT COUNT(*) FROM public.\"User\" WHERE \"Email\" = @Email";
        int count = _dbContext.DbConnection.ExecuteScalar<int>(query, new { Email = email });
        if (count > 0)
        {
            return Task.FromResult(true);
        }
        else
        {
            return Task.FromResult(false);
        }
    }
}
