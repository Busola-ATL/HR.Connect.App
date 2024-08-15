using HR.Connect.App.MVVM.Views;

namespace HR.Connect.App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var navPage = new NavigationPage(new LoginPageView());
            navPage.BarBackgroundColor = Colors.DarkRed;
            navPage.BarTextColor = Colors.White;

            MainPage = navPage;

            var navPage2 = new NavigationPage(new AdminPanelPage());
            navPage2.BarBackgroundColor = Colors.DarkRed;
            navPage2.BarTextColor = Colors.White;

        }
    }
}
