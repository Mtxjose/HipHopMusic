using HipHopMusic.Views;
namespace HipHopMusic;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("canciones", typeof(CancionesPage));
        Routing.RegisterRoute("detallecancion", typeof(DetalleCancionPage)); 

       
    }
}

