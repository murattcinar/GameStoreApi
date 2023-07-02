using GameStore.Api.Entities;

namespace GameStore.Api.Repositories;

public interface IGamesRepository
{
    Task CreateAsync(Game game);
    Task DeleteAsyc(int id);
    Task<Game?>  GetAsync(int id);
    Task<IEnumerable<Game>> GetAllAynsc();
    Task UpdateAsync(Game updateGame);
}
