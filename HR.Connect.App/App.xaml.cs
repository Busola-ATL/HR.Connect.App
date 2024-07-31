using HR.Connect.App.MVVM.Views;

namespace HR.Connect.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPageView();
        }
    }
}
