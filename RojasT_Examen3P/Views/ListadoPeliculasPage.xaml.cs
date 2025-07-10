public partial class ListadoPeliculasPage : ContentPage
{
    PeliculaDatabase _db;
    public ListadoPeliculasPage(PeliculaDatabase db)
    {
        InitializeComponent();
        _db = db;
    } 

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        ListaPeliculas.ItemsSource = await _db.GetPeliculasAsync();
    }
}
