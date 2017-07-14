using Formula1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Formula1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RaceSchedulePage : ContentPage
	{
		public RaceSchedulePage ()
		{
			InitializeComponent ();
            BindingContext = DataRepository.Races;
        }

        private void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            timelineListView.SelectedItem = null;
        }
    }
}