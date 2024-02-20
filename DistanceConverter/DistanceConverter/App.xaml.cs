using DistanceConverter.views;

namespace DistanceConverter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new StartPage());
	}
}

