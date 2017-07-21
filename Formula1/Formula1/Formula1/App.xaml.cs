using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Formula1.Views;
using Xamarin.Forms;

namespace Formula1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Content Page
            MainPage = new DriverDetailsPage(Data.DataRepository.Drivers[0]);

            // Stack / Hierarchical navigation
            //MainPage = new NavigationPage(new Formula1.DriverRankingsPage())
            //{
            //    BarBackgroundColor = Color.FromHex("#9E4368"),
            //    BarTextColor = Color.White
            //};

            // Tabbed Page
            //MainPage = new TabbedContainer();

            // Master Detail Page
            //MainPage = new MasterDetailContainer();

            //if (Device.RuntimePlatform == Device.iOS)
            //    MainPage = new TabbedContainer();
            //else
                //MainPage = new MasterDetailContainer();



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
