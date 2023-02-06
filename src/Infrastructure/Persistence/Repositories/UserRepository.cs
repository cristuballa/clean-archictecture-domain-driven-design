using Application.Common.Interfaces;
using Domain.Entities;

namespace Infrastructure.Persistence
{
    public class UserRepository : IUserRepository
    {
        private readonly KctImsDbContext _context;

        public UserRepository(KctImsDbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users?.FirstOrDefault(u => u.Email == email);
        }
    }
}