using Navigation.NavPages;

namespace Navigation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new NavPage1());
		//MainPage = new AppShell();
	}
}
