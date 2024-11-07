using BuberDinner.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BuberDinner.Application;

public static class DepedencyInjection
{
    public static ServiceCollection AddApplication (this IServiceCollection services){
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return (ServiceCollection)services;
    }
}