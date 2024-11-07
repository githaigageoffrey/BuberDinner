using BuberDinner.Application.Common.interfaces.Authentication;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{

    private readonly IJwtTokeGenerator _jwtTokeGenerator;

    public AuthenticationService(IJwtTokeGenerator jwtTokeGenerator){
        _jwtTokeGenerator = jwtTokeGenerator;
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token"
        );
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //check if user existis

        // create user

        // generate jwt token
        Guid userId = Guid.NewGuid();

        var token = _jwtTokeGenerator.GenerateToken(userId, firstName, lastName);
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            token
        );
    }
}