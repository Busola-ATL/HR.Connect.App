using HR.Connect.App.MVVM.ViewModels;

namespace HR.Connect.App.MVVM.Views;

public partial class EmployeeDetail : ContentPage
{
	public EmployeeDetail()
	{
		InitializeComponent();
		BindingContext = new EmployeeDetailViewModel();
	}
}