using eCommerce.Core.Entities;

namespace eCommerce.Core.RepositoryContracts;
public interface IUserRepository
{
    public Task<ApplicationUser> AddUser(ApplicationUser user);
    public Task<ApplicationUser> GetUserByEmailAndPassword(string? email, string? password);
    public Task<bool> IsEmailAlreadyExists(string? email);
    public Task<List<ApplicationUser>> GetUsers();
}
