using HR.Connect.App.MVVM.ViewModels;

namespace HR.Connect.App.MVVM.Views;

public partial class LoginPageView : ContentPage
{
	public LoginPageView()
	{
		InitializeComponent();
		BindingContext = new LoginPageViewModel();


	 }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }
}