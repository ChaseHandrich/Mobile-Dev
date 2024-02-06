namespace DateNight.Views;

public partial class MoviePage : ContentPage
{
	public MoviePage()
	{
		InitializeComponent();
		Title = "Going to the Movies";
	}
    protected override void OnDisappearing()
    {
		App.dateCalc.MovieCost = txtMovie.Text;
        base.OnDisappearing();
    }
}
