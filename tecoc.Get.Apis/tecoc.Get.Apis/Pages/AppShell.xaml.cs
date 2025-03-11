namespace Tecoc.Get.Apis.Pages;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(OtherPage), typeof(OtherPage));
	}
}