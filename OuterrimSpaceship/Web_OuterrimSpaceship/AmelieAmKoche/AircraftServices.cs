namespace Web_OuterrimSpaceship.AmelieAmKoche;

using Model_OuterrimSpaceship.Repos;
using Web_OuterrimSpaceship.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AircraftService
{
    private readonly IRepositoryAsync<Aircrafts> _repository;

    public AircraftService(IRepositoryAsync<Aircrafts> repository)
    {
        _repository = repository;
    }

    public async Task<List<Aircrafts>> GetAllAircraftsAsync()
    {
        return await _repository.ReadAllAsync();
    }
    
    public async Task<Aircrafts?> GetAircraftByIdAsync(int id)
    {
        return await _repository.ReadAsync(id);
    }

    public async Task AddAircraftAsync(Aircrafts aircraft)
    {
        await _repository.CreateAsync(aircraft);
    }

    public async Task UpdateAircraftAsync(Aircrafts aircraft)
    {
        await _repository.UpdateAsync(aircraft);
    }

    public async Task DeleteAircraftAsync(Aircrafts aircraft)
    {
        await _repository.DeleteAsync(aircraft);
    }
}
