namespace Navigation.NavPages;

public partial class NavPage1 : ContentPage
{
	public NavPage1()
	{
		InitializeComponent();
	}
    //Navigate to nav page 2/3 without animation
    private void ButtonToNavePage2_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NavPage2());
	}
	private void ButtonToNavePage3_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NavPage3());
	}
    protected override bool OnBackButtonPressed()
    {
        // Prevent going back to previous pages
        return true;
    }
}