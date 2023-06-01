namespace Navigation;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    //Click button to page 2
    private void ButtonToPage2_Clicked(object sender, EventArgs e)
    {
        //Animation of entering of the second page from the low
        Navigation.PopModalAsync();
    }

    //Click button to page Home
    private void ButtonToHome_Clicked(object sender, EventArgs e)
    {
        //Animation of entering of the Home from the low
        Navigation.PushModalAsync(new MainPage());
    }
}