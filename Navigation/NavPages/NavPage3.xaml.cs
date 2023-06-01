using Navigation.NavPages;

namespace Navigation;

public partial class NavPage3 : ContentPage
{
	public NavPage3()
	{
		InitializeComponent();
	}
    //Navigate to nav page 1/back without animation
    private void ButtonToNavPage1_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NavPage1());
    }
    private void ButtonToBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}