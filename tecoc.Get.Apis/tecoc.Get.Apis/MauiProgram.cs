using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using RestSharp;
using Tecoc.Get.Apis.Repositories;
using Tecoc.Get.Apis.Repositories.interfaces;
using Tecoc.Get.Apis.ViewModels;
using UraniumUI;

namespace Tecoc.Get.Apis;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseUraniumUI()
			.UseUraniumUIMaterial()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});



		builder.Services.AddTransient<IUserRepository, UserRepository>();
		builder.Services.AddSingleton<IRestClient>(new RestClient());
		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<OtherViewModel>();

		return builder.Build();
	}
}
