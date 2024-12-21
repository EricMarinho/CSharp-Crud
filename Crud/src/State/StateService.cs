using Crud.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud.src.State
{
    public class StateService
    {
        private readonly CrudDbContext _context;

        public StateService(CrudDbContext context)
        {
            _context = context;
        }

        public async Task<List<StateEntity>> GetStates()
        {
            List<StateEntity> result = await _context.States.ToListAsync();
            return result;
        }

        public async Task<StateEntity?> GetState(Guid id)
        {
            StateEntity? result = await _context.States.FindAsync(id);
            return result;
        }

        public async Task PostState(StateEntity state)
        {
            _context.States.Add(state);
            await _context.SaveChangesAsync();
        }

        public async Task PutState(StateEntity state)
        {
            _context.States.Update(state);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteState(Guid id)
        {
            StateEntity? state = await _context.States.FindAsync(id);
            _context.States.Remove(state);
            await _context.SaveChangesAsync();
        }
    }
}
