using SQLite;
using RojasT_Examen3P.Models;

namespace RojasT_Examen3P.Services;

public class PeliculaDatabase
{
    private readonly SQLiteAsyncConnection _database;

    public PeliculaDatabase(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Pelicula>().Wait();
    }

    public Task<List<Pelicula>> GetPeliculasAsync() =>
        _database.Table<Pelicula>().ToListAsync();

    public Task<int> InsertPeliculaAsync(Pelicula pelicula) =>
        _database.InsertAsync(pelicula);
}


