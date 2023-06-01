namespace Navigation;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    //Animation of entering of the second/third page from the low

    //Click button to page 2
    private void ButtonToPage2_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Page2());
	}

	//Click button to page 3
	private void ButtonToPage3_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new Page3());	
	}
    protected override bool OnBackButtonPressed()
    {
        // Prevent going back to previous pages
        return true;
    }
}

