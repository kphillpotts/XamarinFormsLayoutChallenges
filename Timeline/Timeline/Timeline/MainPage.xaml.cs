using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Timeline
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = DataFactory.Classes;
        }

        private void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            timelineListView.SelectedItem = null;
        }
    }
}
