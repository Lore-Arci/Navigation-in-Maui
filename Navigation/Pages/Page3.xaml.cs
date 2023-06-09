namespace Navigation;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    //Click button to page 2
    private void ButtonToHome_Clicked(object sender, EventArgs e)
    {
        //Animation of entering of the second page from the low
        Navigation.PushModalAsync(new MainPage());
    }

    //Click button to page Home
    private void ButtonToBack_Clicked(object sender, EventArgs e)
    {
        //Animation of entering of the Home from the low
        Navigation.PopModalAsync();
    }
    protected override bool OnBackButtonPressed()
    {
        // Prevent going back to previous pages
        return true;
    }
}