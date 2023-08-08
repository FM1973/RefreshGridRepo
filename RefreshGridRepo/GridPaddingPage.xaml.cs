namespace RefreshGridRepo;

public partial class GridPaddingPage : ContentPage
{
	public GridPaddingPage()
	{
		InitializeComponent();
	}

    private void btnNoPadding_Clicked(object sender, EventArgs e)
    {
        rootGrid.Padding = new Thickness(0);
    }

    private void btnPadding20_Clicked(object sender, EventArgs e)
    {
        rootGrid.Padding = new Thickness(20);
    }

    private void btnPadding50_Clicked(object sender, EventArgs e)
    {
        rootGrid.Padding = new Thickness(50);
    }
}