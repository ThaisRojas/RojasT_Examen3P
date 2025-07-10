namespace RojasT_Examen3P;

public partial class App : Application
{
    static PeliculaDatabase database;

    public static PeliculaDatabase Database
    {
        get
        {
            if (database == null)
            {
                var path = Path.Combine(FileSystem.AppDataDirectory, "peliculas.db3");
                database = new PeliculaDatabase(path);
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
