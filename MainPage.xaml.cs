namespace DTIapp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método para lidar com o evento de clique dos botões principais
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button != null)
            {
                // Ações com base no texto do botão
                switch (button.Text)
                {
                    case "load items":
                        await DisplayAlert("Action", "Loading items...", "OK");
                        break;

                    case "create clothes":
                        await DisplayAlert("Action", "Opening clothes creation screen...", "OK");
                        break;

                    case "schedule clothes":
                        await DisplayAlert("Action", "Scheduling clothes...", "OK");
                        break;

                    case "see my statistics":
                        await DisplayAlert("Action", "Showing statistics...", "OK");
                        break;
                }
            }
        }

        // Método para a funcionalidade da barra de pesquisa
        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue;

            // Exemplo de ação com base na pesquisa
            if (!string.IsNullOrEmpty(searchText))
            {
                Console.WriteLine($"Search initiated for: {searchText}");
            }
        }

        // Método para lidar com o clique nos ícones da barra de navegação inferior
        private async void OnNavIconClicked(object sender, EventArgs e)
        {
            var image = sender as Image;

            if (image != null)
            {
                // Exemplo de navegação ou ação com base no ícone
                if (image.Source.ToString().Contains("home_icon"))
                {
                    await DisplayAlert("Navigation", "Going to Home Screen...", "OK");
                }
                else if (image.Source.ToString().Contains("cart_icon"))
                {
                    await DisplayAlert("Navigation", "Opening Cart...", "OK");
                }
                else if (image.Source.ToString().Contains("globe_icon"))
                {
                    await DisplayAlert("Navigation", "Opening Web View...", "OK");
                }
                else if (image.Source.ToString().Contains("calendar_icon"))
                {
                    await DisplayAlert("Navigation", "Opening Calendar...", "OK");
                }
            }
        }
    }
}
