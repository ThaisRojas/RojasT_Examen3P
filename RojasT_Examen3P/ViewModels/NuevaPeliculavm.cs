using RojasT_Examen3P.Models;
using RojasT_Examen3P.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace RojasT_Examen3P.ViewModels;

public class NuevaPeliculavm : INotifyPropertyChanged
{
    public string Titulo { get; set; }
    public string Genero { get; set; }
    public int AnioEstreno { get; set; }
    public int Calificacion { get; set; }

    public ICommand GuardarCommand { get; }

    private PeliculaDatabase _db;
    private string _logPath;

    public NuevaPeliculavm(PeliculaDatabase db)
    {
        _db = db;
        _logPath = Path.Combine(FileSystem.AppDataDirectory, "Logs_Rojas.txt");
        GuardarCommand = new Command(async () => await Guardar());
    }

    public event PropertyChangedEventHandler PropertyChanged;

    private async Task Guardar() 
    {
        if (Calificacion < 3 || AnioEstreno < 2024)  
        {
            await Application.Current.MainPage.DisplayAlert("Error", "Mensaje de error", "Error");
            return;
        }

        var pelicula = new Pelicula
        {
            Titulo = this.Titulo,
            Genero = this.Genero,
            AnioEstreno = this.AnioEstreno,
            Calificacion = this.Calificacion
        };

        await _db.InsertPeliculaAsync(pelicula);
        File.AppendAllText(_logPath, $"Se incluyó el registro [{pelicula.Titulo}] el {DateTime.Now:dd/MM/yyyy HH:mm}\n");

        await Shell.Current.DisplayAlert("Guardado" , "OK" , "Pelicula Guardada");

        Titulo = Genero = string.Empty;
        AnioEstreno = Calificacion = 0;
        OnPropertyChanged(nameof(Titulo));
        OnPropertyChanged(nameof(Genero));
        OnPropertyChanged(nameof(AnioEstreno));
        OnPropertyChanged(nameof(Calificacion));
    }

    protected void OnPropertyChanged([CallerMemberName] string name = "")
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

