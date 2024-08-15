using HR.Connect.App.MVVM.Models;
using System.Data;
using System.Xml.Linq;

namespace HR.Connect.App.MVVM.Views;

public partial class AdminPanelPage : ContentPage
{
    public AdminPanelPage()
    {
        InitializeComponent();
        BindingContext = new AdminPanelModel();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EmployeeDetail());
    }

    private void empName_Search(object sender, EventArgs e)
    {
        var emp = empName.Text;

        if (emp != null)
        {
            empLabel.Text = emp;
        }

        AdminPanelModel firsEmployee = new AdminPanelModel()
        {
            Name = "aminat",
            Role = "Software Developer",
            PhoneNum = "+1 768 875 7856",
            Email = "Aminat@gmail.com",
            Department = "Information Technology",
            Location = "Toronto Ontario"
        };

        Binding empBinding =
            new Binding();
        empBinding.Source = firsEmployee;
        empBinding.Path = "Role";
        txtRole.SetBinding(Entry.TextProperty, empBinding);

    }
    
}