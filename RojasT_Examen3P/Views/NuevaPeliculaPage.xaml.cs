using RojasT_Examen3P.Services;
using RojasT_Examen3P.ViewModels;

namespace RojasT_Examen3P.Views;

public partial class NuevaPeliculaPage : ContentPage
{
    public NuevaPeliculaPage()
    {
        InitializeComponent();
        BindingContext = new NuevaPeliculavm(App.Database);
    }
}


