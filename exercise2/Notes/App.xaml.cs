namespace Notes;

public partial class App : Application
{
    public static ViewModels.MovieListViewModel? MainViewModel { get; private set; }
    public App()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(Notes.WeatherClient), typeof(Notes.WeatherClient));
    }

	protected override Window CreateWindow(IActivationState activationState)
	{
        var window = new Window(new AppShell());

        MainViewModel = new();
        MainViewModel.RefreshMovies().ContinueWith((s) => { });

        return window;
    }
}