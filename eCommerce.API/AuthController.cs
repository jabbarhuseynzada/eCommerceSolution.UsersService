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

        [Route("Register")]
        public async Task<IActionResult>Register(RegisterRequest registerRequest)
        {
            if(registerRequest == null)
            {
                return BadRequest("Invalid Registration Data");

            }
            AuthenticationResponse authenticationResponse = await _service.Register(registerRequest);
            if(authenticationResponse == null || authenticationResponse.Success == false)
            {
                return BadRequest(authenticationResponse);
            }

            return Ok(authenticationResponse);
        }
        [HttpPost("login")]
        public async Task<IActionResult?> Login(LoginRequest loginRequest)
        {
            if(loginRequest == null)
            {
                return BadRequest("Invalid login data");
            }
            AuthenticationResponse authenticationResponse = await _service.Login(loginRequest);

            if(authenticationResponse == null || authenticationResponse?.Success == false)
            {
                return Unauthorized(authenticationResponse);
            }
            return Ok(authenticationResponse);
        }
    }
}
