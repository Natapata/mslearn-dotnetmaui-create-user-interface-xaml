namespace Notes;
public partial class AlignmentPage : ContentPage
{
    readonly Color _inactive = (Color)Application.Current.Resources["Light"];
    readonly Color _active = (Color)Application.Current.Resources["Primary"];

    public AlignmentPage()
	{
		InitializeComponent();
	}
    void OnHorizontalStartClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Start; HighlightButton((Button)sender, HButtons); }
    void OnHorizontalCenterClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Center; HighlightButton((Button)sender, HButtons); }
    void OnHorizontalEndClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.End; HighlightButton((Button)sender, HButtons); }
    void OnHorizontalFillClicked(object sender, EventArgs e) { target.HorizontalOptions = LayoutOptions.Fill; HighlightButton((Button)sender, HButtons); }
    void OnVerticalStartClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Start; HighlightButton((Button)sender, VButtons); }
    void OnVerticalCenterClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Center; HighlightButton((Button)sender, VButtons); }
    void OnVerticalEndClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.End; HighlightButton((Button)sender, VButtons); }
    void OnVerticalFillClicked(object sender, EventArgs e) { target.VerticalOptions = LayoutOptions.Fill; HighlightButton((Button)sender, VButtons); }
    void HighlightButton(Button clicked, Layout group)
    {
        foreach (var button in group.Children.OfType<Button>())
        {
            button.BackgroundColor = _inactive;
            button.TextColor = (Color)Application.Current.Resources["Primary"];

            clicked.BackgroundColor = _active;
            clicked.TextColor = (Color)Application.Current.Resources["White"];

        }
    }
}