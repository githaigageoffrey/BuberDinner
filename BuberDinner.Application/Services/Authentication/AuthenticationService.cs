using BuberDinner.Application.Common.interfaces.Authentication;
using BuberDinner.Application.Common.interfaces.Persistence;
using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{

    private readonly IJwtTokeGenerator _jwtTokeGenerator;

    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokeGenerator jwtTokeGenerator,IUserRepository userRepository){
        _jwtTokeGenerator = jwtTokeGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Login(string email, string password)
    {
        //1. validate user exists
        if(_userRepository.GetUserByEmail(email) is not User user){
            throw new Exception("User with given Email does not exist");
        }

        //2. validate password is okay
        if(user.Password != password){
            throw new Exception("Incorrect login credentials");
        }
        //3. generate JWT Token
        var token = _jwtTokeGenerator.GenerateToken(user.Id,user.FirstName,user.LastName);
        return new AuthenticationResult(
            user.Id,
            user.FirstName,
            user.LastName,
            email,
            token
        );
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        //1. check if user does not existis
        if(_userRepository.GetUserByEmail(email) is not null){
            throw new Exception("User with given email already exists");
        }

        //2. create user (generate uuid ) and persist in the db
       var user = new User(firstName, lastName, email, password);
        _userRepository.Add(user);

        //3. generate jwt token

        var token = _jwtTokeGenerator.GenerateToken(user.Id, firstName, lastName);
        return new AuthenticationResult(
            user.Id,
            firstName,
            lastName,
            email,
            token
        );
    }
}