using MovieApp.models;
namespace MovieApp.views;

public partial class AddPage : ContentPage
{
	public AddPage()
	{
		InitializeComponent();
	}

    void Add_Clicked(System.Object sender, System.EventArgs e)
    {
		var nm = new Movie();
		nm.Title = txtTitle.Text;
		nm.Rating = txtRating.Text;

		App.MovieList.saveMovie(nm);

		txtTitle.Text = "";
		txtRating.Text = "";
    }
}
