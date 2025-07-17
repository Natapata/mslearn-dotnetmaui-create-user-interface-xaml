using CommunityToolkit.Mvvm.ComponentModel;

namespace Notes.ViewModels;

public partial class MovieViewModel : ObservableObject
{
    // not using ObservableProperty here to manually implement INotifyPropertyChanged
    private string _title;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    // using ObservableProperty to automatically implement INotifyPropertyChanged
    [ObservableProperty]
    private string _studio;

    [ObservableProperty]
    private string _director;

    [ObservableProperty]
    private DateOnly _year;

    public MovieViewModel(Models.Movie movie)
    {
        _title = movie.Title;
        _studio = movie.Studio;
        _director = movie.Director;
        _year = new DateOnly(movie.Year, 1, 1);
    }
}