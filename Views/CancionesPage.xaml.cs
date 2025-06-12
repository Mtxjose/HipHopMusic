using HipHopMusic.ViewModels;
using HipHopMusic.Models;
using System;


namespace HipHopMusic.Views;
[QueryProperty(nameof(Artista), "artista")]
public partial class CancionesPage : ContentPage
{
    public string Artista
    {
        set
        {
            // Aquí se crea el ViewModel dinámicamente con el nombre recibido
            BindingContext = new CancionesViewModel(Uri.UnescapeDataString(value));
        }
    }

    public CancionesPage()
    {
        InitializeComponent();
    }

    private async void OnCancionSeleccionada(object sender, SelectionChangedEventArgs e)
    {
        var cancion = e.CurrentSelection.FirstOrDefault() as Cancion;
        if (cancion != null)
        {
            var cancionJson = Uri.EscapeDataString(System.Text.Json.JsonSerializer.Serialize(cancion));
            await Shell.Current.GoToAsync($"detallecancion?cancion={cancionJson}");
        }

        ((CollectionView)sender).SelectedItem = null;
    }
}
