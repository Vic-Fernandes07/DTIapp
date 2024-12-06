namespace DTIapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
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
                    case "load items":
                        // Navegar para a página de Load Items
                        await Navigation.PushAsync(new LoadItemsPage());
                        break;

                    case "create clothes":
                        // Navegar para a página de Create Clothes
                        await Navigation.PushAsync(new CreateClothesPage());
                        break;

                    case "schedule clothes":
                        // Navegar para a página de Schedule Clothes
                        await Navigation.PushAsync(new ScheduleClothesPage());
                        break;

                    case "see my statistics":
                        // Navegar para a página de Statistics
                        await Navigation.PushAsync(new StatisticsPage());
                        break;

                    default:
                        await DisplayAlert("Error", "Unknown action.", "OK");
                        break;
                }
            }
        }
<<<<<<< Updated upstream
=======

        private async void Star_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoadItemsPage());
        }

        private async void Carrinho_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CartPage());
        }

        private async void Globo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GlobePage());
        }

        private async void Calendario_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScheduleClothesPage());
        }

        private async void Guardaroupa_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WardrobePage());
        }
>>>>>>> Stashed changes
    }
}
