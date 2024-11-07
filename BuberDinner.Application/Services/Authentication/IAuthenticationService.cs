namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(String email,String password);
    AuthenticationResult Register(String firstName, String lastName, String email,String password);
}