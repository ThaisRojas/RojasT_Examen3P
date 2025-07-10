using RojasT_Examen3P.Services;
using Microsoft.Maui.Controls;

namespace RojasT_Examen3P.Views;

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
