using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services;
public class UserService(IUserRepository repository, IMapper mapper) : IUserService
{
    private readonly IUserRepository _userRepository = repository;
    private readonly IMapper _mapper = mapper;

    public async Task<List<AuthenticationResponse>> GetUsers()
    {
        List<ApplicationUser> users = await _userRepository.GetUsers();
        if (users == null || users.Count == 0)
        {
            return new List<AuthenticationResponse>();
        }
        return _mapper.Map<List<AuthenticationResponse>>(users);
    }

    public async Task<AuthenticationResponse> Login(LoginRequest loginRequest)
    {
        ApplicationUser user = await _userRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
        //if (user == null)
        //{
        //    return null;
        //}
        //return new AuthenticationResponse(user.UserId, user.Email, user.PersonName, user.Gender, "token", Success: true);
        return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token" };
    }

    public async Task<AuthenticationResponse> Register(RegisterRequest registerRequest)
    {
        ApplicationUser user = _mapper.Map<ApplicationUser>(registerRequest);
        bool check = await _userRepository.IsEmailAlreadyExists(registerRequest.Email);
        if (check)
        {
            return new AuthenticationResponse() { Success = false, Token = "token"};
        }
        ApplicationUser registeredUser = await _userRepository.AddUser(user);
        /*if (registerRequest.Email == null)
        {
            return null;
        }*/
        
       

        //return new AuthenticationResponse(registeredUser.UserId, registeredUser.Email, registeredUser.PersonName, registeredUser.Gender, "Token", Success: true);
        return _mapper.Map<AuthenticationResponse>(registeredUser) with { Success = true, Token = "token" };
    }
}
