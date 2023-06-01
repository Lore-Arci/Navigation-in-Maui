namespace Navigation;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    //Animation of entering of the 3/Home from the low

    //Click button to page 3
    private void ButtonToPage3_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new Page3());
    }

    //Click button to page Home
    private void ButtonToHome_Clicked(object sender, EventArgs e)
    {
        //Animation of closing of the second page from the high
        Navigation.PopModalAsync();
    }
    protected override bool OnBackButtonPressed()
    {
        // Prevent going back to previous pages
        return true;
    }
}