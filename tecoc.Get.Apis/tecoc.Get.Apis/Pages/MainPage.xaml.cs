using Tecoc.Get.Apis.ViewModels;

namespace Tecoc.Get.Apis.Pages;

public partial class MainPage : ContentPage
{

	public MainViewModel vm { get; set; }

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = this.vm = vm;

	}


	protected override void OnAppearing()
	{
		base.OnAppearing();
		vm.GetPersons();



	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		//await ((MainViewModel)BindingContext).GetPersons();
		//await ((MainViewModel)BindingContext).GetPersons();	
	}
}