namespace Navigation.NavPages;

public partial class NavPage2 : ContentPage
{
	public NavPage2()
	{
		InitializeComponent();
	}
    //Navigate to nav page back/3 without animation
    private void ButtonToBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void ButtonToNavePage3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NavPage3());
    }
}