﻿namespace RefreshGridRepo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(TestPage1), typeof(TestPage1));
        Routing.RegisterRoute(nameof(TestPage2), typeof(TestPage2));
        Routing.RegisterRoute(nameof(TestPage5), typeof(TestPage5));
    }
}
