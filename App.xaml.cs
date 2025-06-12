namespace HipHopMusic;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell(); // Inicia con navegación por Shell
    }
}
