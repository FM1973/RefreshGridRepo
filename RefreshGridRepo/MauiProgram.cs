using CommunityToolkit.Maui;
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
		builder.Services.AddTransient<MessagesViewModel>();
		builder.Services.AddSingleton<MainPage1ViewModel>();
		builder.Services.AddSingleton<MainPage2ViewModel>();
		builder.Services.AddSingleton<MainPage3ViewModel>();
		builder.Services.AddSingleton<MainPage4ViewModel>();
		builder.Services.AddTransient<SubPage1ViewModel>();
        builder.Services.AddTransient<SubPage2ViewModel>();


        builder.Services.AddTransient<TestPage1>();
		builder.Services.AddTransient<TestPage2>();
        builder.Services.AddTransient<TestPage3>();
        builder.Services.AddTransient<TestPage4>();
        builder.Services.AddTransient<TestPage5>();

        builder.Services.AddTransient<MessagesPage>();

		builder.Services.AddSingleton<MainPage1>();
		builder.Services.AddSingleton<MainPage2>();
		builder.Services.AddSingleton<MainPage3>();
		builder.Services.AddSingleton<MainPage4>();
		builder.Services.AddTransient<SubPage1>();
        builder.Services.AddTransient<SubPage2>();

        return builder.Build();
	}
}
