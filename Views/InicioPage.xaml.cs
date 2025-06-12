using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace HipHopMusic.Views
{
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
        }

        // Método que se ejecuta cuando se hace clic en el botón "¡Dale al Beat!"
        private async void BotonEntrar_Clicked(object sender, EventArgs e)
        {
            // Navega a la ruta "artistas" que definiste en tu AppShell.xaml
            await Shell.Current.GoToAsync("///artistas");
        }
    }
}