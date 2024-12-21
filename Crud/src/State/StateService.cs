using Crud.Data;
using Crud.src.State.dto;
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

        public async Task<StateEntity> PostState(CreateStateDto stateDto)
        {
            StateEntity state = new StateEntity();

            state.Name = stateDto.Name;
            state.Abreviation = stateDto.Abreviation;
            state.Area = stateDto.Area;

            _context.States.Add(state);
            await _context.SaveChangesAsync();

            return state;
        }

        public async Task<StateEntity> PutState(Guid id, CreateStateDto stateDto)
        {
            StateEntity? state = await _context.States.FindAsync(id);

            if (state == null) throw new Exception("State not found");

            state.Name = stateDto.Name;
            state.Abreviation = stateDto.Abreviation;
            state.Area = stateDto.Area;


            _context.States.Update(state);
            await _context.SaveChangesAsync();

            return state;
        }

        public async Task DeleteState(Guid id)
        {
            StateEntity? state = await _context.States.FindAsync(id);

            if(state == null) throw new Exception("State not found");

            _context.States.Remove(state);
            await _context.SaveChangesAsync();
        }
    }
}
