namespace HR.Connect.App.MVVM.Views;

public partial class AdminPanelPage : ContentPage
{
	public AdminPanelPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		 Navigation.PushAsync(new EmployeeDetail());
    }

    private  void  empName_Search(object sender, EventArgs e)
    {
        var emp = empName.Text;

        if(emp  != null)
        {
          empLabel.Text = emp;
        }
       
    }
}