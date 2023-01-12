using Domain.Entities;

namespace Application.Common.Interfaces
{
    public interface IUserRepository
    {
        public User GetUserByEmail(string email);
        public User CreateUser(User user);
    }
}