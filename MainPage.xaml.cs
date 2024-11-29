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
    }
}
