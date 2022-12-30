namespace RefreshGridRepo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TestPage1), typeof(TestPage1));
        Routing.RegisterRoute(nameof(TestPage2), typeof(TestPage2));
        Routing.RegisterRoute(nameof(TestPage3), typeof(TestPage3));
        Routing.RegisterRoute(nameof(TestPage4), typeof(TestPage4));
        Routing.RegisterRoute(nameof(TestPage5), typeof(TestPage5));

        Routing.RegisterRoute(nameof(MessagesPage), typeof(MessagesPage));

        Routing.RegisterRoute(nameof(SubPage1), typeof(SubPage1));
        Routing.RegisterRoute(nameof(SubPage2), typeof(SubPage2));
    }
}
