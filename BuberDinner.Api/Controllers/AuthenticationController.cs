using BuberDinner.Contracts.Authentication;
using BuberDinner.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService){
        _authenticationService = authenticationService;
    }


    [HttpPost("register")]
    public ActionResult Register(RegisterRequest request){
        var authResult = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);

         var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        return Ok(response);
    }


    [HttpPost("login")]
    public ActionResult Login(LoginRequest request){
        Console.WriteLine(request);
        
        var authResult = _authenticationService.Login(request.Email, request.Password);
        // Console.WriteLine(authResult);
        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName, 
            authResult.LastName,
            authResult.Email,
            authResult.Token
        );
        return Ok(response);
    }

}