using Crud.Data;

namespace Crud.src.User
{
    public class UserService
    {
        private readonly CrudDbContext _context;

        public UserService(CrudDbContext context)
        {
            _context = context;
        }
    }
}
