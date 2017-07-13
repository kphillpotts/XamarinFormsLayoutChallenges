using Formula1.Data;
using Formula1.Models;
using Formula1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriverRankingsPage : ContentPage
    {
        public DriverRankingsPage()
        {
            InitializeComponent();
            BindingContext = DataRepository.Drivers;
        }


        private void DriverList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            DriverList.SelectedItem = null;
            Driver selectedDriver = e.Item as Driver;
            this.Navigation.PushAsync(new DriverDetailsPage(selectedDriver));
        }
    }
}