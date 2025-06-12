using HipHopMusic.Models;

namespace HipHopMusic.Views;

public partial class ArtistasPage : ContentPage
{
    public ArtistasPage()
    {
        InitializeComponent();
    }

    private async void OnArtistaSeleccionado(object sender, SelectionChangedEventArgs e)
    {
        var artista = e.CurrentSelection.FirstOrDefault() as Artista;
        if (artista != null)
        {
            var artistaCodificado = Uri.EscapeDataString(artista.Nombre);
            await Shell.Current.GoToAsync($"canciones?artista={artistaCodificado}");
        }

        ((CollectionView)sender).SelectedItem = null; // Quita selección visual
    }
}
