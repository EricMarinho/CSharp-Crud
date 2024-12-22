using Crud.Data;
using Crud.src.City.dto;
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
            List<CityEntity> result = await _context.Cities.Include(x => x.State).ToListAsync();
            return result;
        }

        public async Task<CityEntity?> GetCity(Guid id)
        {
            CityEntity? result = await _context.Cities.Include(x => x.State).FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task PostCity(CreateCityDto cityDto)
        {
            CityEntity city = new CityEntity();

            city.Name = cityDto.Name;
            city.StateId = cityDto.StateId;

            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
        }

        public async Task PutCity(Guid id, CreateCityDto cityDto)
        {
            CityEntity? city = await _context.Cities.FindAsync(id);

            if (city == null) throw new Exception("City not found");

            city.Name = cityDto.Name;
            city.StateId = cityDto.StateId;
            city.UpdatedAt = DateTime.Now.ToString();

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
