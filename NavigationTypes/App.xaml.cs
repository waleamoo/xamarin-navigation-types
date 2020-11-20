using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationTypes
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};


            //MainPage = new NavigationPage(new ContactPage());

            //MainPage = new ContactMasterPage();

            MainPage = new NavigationPage(new TableViewPage());
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
