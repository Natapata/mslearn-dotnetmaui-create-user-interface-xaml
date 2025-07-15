using System.Text.RegularExpressions;

namespace Notes;

public partial class MirroredTimeCalculatorPage : ContentPage
{
	public MirroredTimeCalculatorPage()
	{
		InitializeComponent();
	}

	public void OnTimeInMirrorButtonClicked(object sender, EventArgs e)
	{
		if (timeInMirrorInput.Text == null || !TimeValidation(timeInMirrorInput.Text.Trim()))
		{
			inputError.IsVisible = true;
        }
        else
		{
            inputError.IsVisible = false;
            int[] map = { 0, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 12 };
            string[] time = timeInMirrorInput.Text.Split(':');
            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);

            hour = map[hour];
            if (minute != 0)
            {
                minute = 60 - minute;
                hour -= 1;
            }

            timeInMirror.Text = $"{hour:00}:{minute}";
        }
        
    }

	private bool TimeValidation(string time)
	{
        const string timePattern = @"^(0[1-9]|1[0-2]):([0-5][0-9])$";
         
        var timeRegex = new Regex(timePattern);

        return timeRegex.IsMatch(time);
	}
}