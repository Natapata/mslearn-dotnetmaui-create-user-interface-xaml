namespace Notes;

public partial class WeatherClient : ContentPage
{
    public WeatherClient()
    {
        InitializeComponent();
    }

    private async void btnRefresh_Clicked(object sender, EventArgs e)
    {
        btnRefresh.IsEnabled = false;
        actIsBusy.IsRunning = true;

        BindingContext = await Services.WeatherServer.GetWeather(txtPostalCode.Text);

        btnRefresh.IsEnabled = true;
        actIsBusy.IsRunning = false;
    }
}