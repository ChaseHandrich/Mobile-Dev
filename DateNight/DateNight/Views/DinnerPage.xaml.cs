namespace DateNight.Views;

public partial class DinnerPage : ContentPage
{
	public DinnerPage()
	{
		InitializeComponent();
		Title = "Going out for Dinner";
	}
    protected override void OnDisappearing()
    {
		App.dateCalc.DinnerCost = txtDinner.Text;
        base.OnDisappearing();
    }
}
