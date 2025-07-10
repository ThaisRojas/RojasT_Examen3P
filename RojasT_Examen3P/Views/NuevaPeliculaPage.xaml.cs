public partial class NuevaPeliculaPage : ContentPage
{
    public NuevaPeliculaPage(PeliculaDatabase db)
    {
        InitializeComponent();
        BindingContext = new NuevaPeliculavm(db);
    }
}

