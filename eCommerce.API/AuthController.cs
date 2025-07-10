using eCommerce.Core.DTO;
using eCommerce.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IUserService service) : ControllerBase
    {
        private readonly IUserService _service = service;

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            if (registerRequest == null)
            {
                return BadRequest("Invalid Registration Data");

            }
            AuthenticationResponse authenticationResponse = await _service.Register(registerRequest);
            if (authenticationResponse == null || authenticationResponse.Success == false)
            {
                // If registration fails, return a BadRequest with the error message

                return BadRequest(authenticationResponse);

            }

            return Ok(authenticationResponse);
        }
        [HttpPost("login")]
        public async Task<IActionResult?> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null)
            {
                return BadRequest("Invalid login data");
            }
            AuthenticationResponse authenticationResponse = await _service.Login(loginRequest);

            if (authenticationResponse == null || authenticationResponse?.Success == false)
            {
                return Unauthorized(authenticationResponse);
            }
            return Ok(authenticationResponse);
        }
        [HttpGet("test")]
        public IActionResult GetUsers()
        {
            List<AuthenticationResponse> users = _service.GetUsers().Result;
            if (users == null || users.Count == 0)
            {
                return NotFound("No users found");
            }
            return Ok(users);
        }
    }
}
