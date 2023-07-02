using GameStore.Api.Entities;

namespace GameStore.Api.Repositories;

public class InMemGamesRepository : IGamesRepository
{

    private readonly List<Game> games = new()
    {
        new Game()
        {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99M,
            ReleaseDate = new DateTime(1999, 2, 1),
            ImageUri = "https://placehold.co/100"
        },
        new Game()
        {
            Id = 2,
            Name = "Final Fantsay XIV",
            Genre = "Roleplaying",
            Price = 59.99M,
            ReleaseDate = new DateTime(2010, 9, 20),
            ImageUri = "https://placehold.co/100"
        },
        new Game()
        {
            Id = 3,
            Name = "FIFA 23",
            Genre = "Spots",
            Price = 69.99M,
            ReleaseDate = new DateTime(2010, 9, 27),
            ImageUri = "https://placehold.co/100"
        }
    };

    public async Task<IEnumerable<Game>> GetAllAynsc()
    {
        return await Task.FromResult(games);
    }
    public async Task<Game?> GetAsync(int id)
    {
        return await Task.FromResult(games.Find(game => game.Id == id));
    }

    public async Task CreateAsync(Game game)
    {
        game.Id = games.Max(game => game.Id) + 1;
        games.Add(game);
        await Task.CompletedTask;
    }

    public async Task UpdateAsync(Game updateGame)
    {
        var index = games.FindIndex(game => game.Id == updateGame.Id);
        games[index] = updateGame;
        await Task.CompletedTask;
    }

    public async Task DeleteAsyc(int id)
    {
        var index = games.FindIndex(game => game.Id == id);
        games.RemoveAt(index);

        await Task.CompletedTask;
    }
}