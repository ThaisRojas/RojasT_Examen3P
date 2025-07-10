using RojasT_Examen3P.Views;
using RojasT_Examen3P.Services;

namespace RojasT_Examen3P
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}