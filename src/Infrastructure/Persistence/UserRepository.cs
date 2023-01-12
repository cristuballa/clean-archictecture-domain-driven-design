using Application.Common.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _users = new List<User>();
        public User CreateUser(User user)
        {
            _users.Add(user);
            return user;
        }

        public User GetUserByEmail(string email)
        {
            // var user1 = new User
            // {
            //     Id = Guid.NewGuid().ToString(),
            //     FirstName = "Crispin",
            //     LastName = "Tuballa",
            //     Email = "email@email.com",
            //     Password = "password123"
            // };

            //  _users.Add(user1);
            return _users.FirstOrDefault(u => u.Email == email);
        }
    }
}