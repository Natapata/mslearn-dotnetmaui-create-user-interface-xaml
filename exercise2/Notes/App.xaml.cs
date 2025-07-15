namespace Notes;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Notes.WeatherClient), typeof(Notes.WeatherClient));
    }

	protected override Window CreateWindow(IActivationState activationState)
	{
		return new Window(new AppShell());
	}
}