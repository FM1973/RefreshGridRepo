namespace RefreshGridRepo;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private async void TestCase1Btn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage1)}");
    }

    private async void TestCase2Btn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage2)}");
    }

    private async void TestCase3Btn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage3)}");
    }

    private async void TestCase4Btn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage4)}");
    }

    private async void TestCase5Btn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage5)}");
    }
}

