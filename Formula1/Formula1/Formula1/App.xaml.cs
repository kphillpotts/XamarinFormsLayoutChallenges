using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Formula1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new TabbedContainer();
            MainPage = new MasterDetailContainer();
            //MainPage = new NavigationPage(new Formula1.RaceSchedulePage())
            //{
            //    BarBackgroundColor = Color.FromHex("#9E4368"),
            //    BarTextColor = Color.White
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
