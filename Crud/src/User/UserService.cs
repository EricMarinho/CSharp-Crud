using Crud.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud.src.User
{
    public class UserService
    {
        private readonly CrudDbContext _context;

        public UserService(CrudDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserEntity>> GetUsers()
        {
            List<UserEntity> result = await _context.Users.ToListAsync();
            return result;
        }

        public async Task<UserEntity?> GetUser(Guid id)
        {
            UserEntity? result = await _context.Users.FindAsync(id);
            return result;
        }

        public async Task PostUser(UserEntity user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task PutUser(UserEntity user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUser(Guid id)
        {
            UserEntity? user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
