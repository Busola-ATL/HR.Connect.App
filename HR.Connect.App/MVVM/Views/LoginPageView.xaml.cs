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
		if (User.Text == "Aminat" && password.Text == "1234")
		{
			Navigation.PushAsync(new AdminPanelPage());
		}
		else
		{
			DisplayAlert("Error Message", "Either your password or userName is incorrect!", "Ok");
		}
	}

}