﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using RefreshGridRepo.ViewModels;

namespace RefreshGridRepo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiApp<App>().UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddTransient<TestViewModel>();


		builder.Services.AddTransient<TestPage1>();
        builder.Services.AddTransient<TestPage2>();
        builder.Services.AddTransient<TestPage5>();

        return builder.Build();
	}
}