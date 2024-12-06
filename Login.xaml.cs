namespace DTIapp;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }

    private async void OnButtonClicked(object sender, EventArgs e)
    {
        var button = sender as Button;

        if (button != null)
        {
            // Ações com base no texto do botão
            switch (button.Text)
            {
                case "Entrar":
                    await Navigation.PushAsync(new MainPage());
                    break;
            }
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}