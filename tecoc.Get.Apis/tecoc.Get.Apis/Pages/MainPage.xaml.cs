using Tecoc.Get.Apis.ViewModels;

namespace Tecoc.Get.Apis.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		
	}
}