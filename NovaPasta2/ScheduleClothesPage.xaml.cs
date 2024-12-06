namespace DTIapp.NovaPasta2;

public partial class ScheduleClothesPage : ContentPage
{
	public ScheduleClothesPage()
	{
		InitializeComponent();
	}

    // Evento disparado ao selecionar uma data no calend�rio
    private async void OnDateSelected(object sender, DateChangedEventArgs e)
    {
        // Exemplo: Mostra a data selecionada em um alerta
        await DisplayAlert("Data Selecionada", $"Voc� selecionou {e.NewDate:d}", "OK");

        // Opcional: Abrir a c�mera ao selecionar a data
        await OpenCameraAsync();
    }

    // Evento ao clicar no bot�o de abrir c�mera
    private async void OnOpenCamera(object sender, EventArgs e)
    {
        await OpenCameraAsync();
    }

    // M�todo para abrir a c�mera
    private async Task OpenCameraAsync()
    {
        try
        {
            var photo = await MediaPicker.CapturePhotoAsync();
            if (photo != null)
            {
                // Exemplo: Salvar a foto capturada
                var filePath = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);
                using var stream = await photo.OpenReadAsync();
                using var fileStream = File.OpenWrite(filePath);
                await stream.CopyToAsync(fileStream);

                await DisplayAlert("Foto Capturada", $"Foto salva em: {filePath}", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"N�o foi poss�vel capturar a foto: {ex.Message}", "OK");
        }
    }
}