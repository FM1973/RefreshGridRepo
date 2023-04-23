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

    private async void MessagesBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(MessagesPage)}");
    }

    private async void NavigationBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(MainPage1)}");
    }

    private async void TestButtonBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(TestPage6)}");
    }

    private async void TestIconsBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(Icons)}");
    }
}

