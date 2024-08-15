using CommunityToolkit.Maui.Alerts;
using HR.Connect.App.MVVM.ViewModels;

namespace HR.Connect.App.MVVM.Views;

public partial class EmployeeDetail : ContentPage
{
	public EmployeeDetail()
	{
		InitializeComponent();
		BindingContext = new EmployeeDetailViewModel();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new LoginPageView());
    }

    private void Crud_Btn(object sender, EventArgs e)
    {
        var toast = Toast.Make("Coming soon!", CommunityToolkit.Maui.Core.ToastDuration.Short, 12);
        toast.Show();
    }
}