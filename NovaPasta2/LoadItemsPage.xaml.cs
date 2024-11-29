namespace DTIapp
{
    public partial class LoadItemsPage : ContentPage
    {
        public LoadItemsPage()
        {
            InitializeComponent();
        }

        private async void OnGoBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Voltar para a MainPage
        }
    }
}
