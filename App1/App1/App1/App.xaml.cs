using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Page1();
            // MainPage = new NavigationPage(new NavigationPageView());
            // MainPage = new TabbedViewPage();
            //MainPage = new carouselpageView();
            // MainPage = new ModalPageView();
            //MainPage = new StackLayout();
            //MainPage = new GridLayoutPage();
            MainPage = new Views.LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
