using Crud.Data;
using Microsoft.EntityFrameworkCore;

namespace Crud.src.City
{
    public class CityService
    {
        private readonly CrudDbContext _context;

        public CityService(CrudDbContext context)
        {
            _context = context;
        }

        public async Task<List<CityEntity>> GetCities()
        {
            List<CityEntity> result = await _context.Cities.ToListAsync();
            return result;
        }

        public async Task<CityEntity?> GetCity(Guid id)
        {
            CityEntity? result = await _context.Cities.FindAsync(id);
            return result;
        }

        public async Task PostCity(CityEntity city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
        }

        public async Task PutCity(CityEntity city)
        {
            _context.Cities.Update(city);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCity(Guid id)
        {
            CityEntity? city = await _context.Cities.FindAsync(id);
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
        }
    }
}
