namespace DTIapp;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        // Envolver a MainPage em um NavigationPage
        MainPage = new NavigationPage(new Login());
    }
}
