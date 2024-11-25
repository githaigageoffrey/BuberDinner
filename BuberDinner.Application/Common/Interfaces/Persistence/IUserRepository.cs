using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.interfaces.Persistence;

public interface IUserRepository{
    
    User? GetUserByEmail(string email);
    void Add(User user);
}