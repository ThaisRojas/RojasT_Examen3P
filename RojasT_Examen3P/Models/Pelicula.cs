using SQLite;

namespace RojasT_Examen3P.Models;

public class Pelicula
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int AnioEstreno { get; set; }
    public int Calificacion { get; set; }
}


