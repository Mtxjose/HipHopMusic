using HipHopMusic.Models;
using Microsoft.Maui.Animations;
using System.Text.Json;

namespace HipHopMusic.Views;

[QueryProperty(nameof(CancionJson), "cancion")]
public partial class DetalleCancionPage : ContentPage
{
    public string CancionJson
    {
        set
        {
            var json = Uri.UnescapeDataString(value);
            var cancion = JsonSerializer.Deserialize<Cancion>(json);

            if (cancion != null)
            {
                ImagenCancion.Source = cancion.Imagen;
                NombreCancion.Text = cancion.Nombre;
                Anio.Text = $"A�o: {cancion.Anio}";
                Duracion.Text = $"Duraci�n: {cancion.Duracion}";
                Letra.Text = cancion.Letra;
            }
        }
    }

    public DetalleCancionPage()
    {
        InitializeComponent();
    }
}
