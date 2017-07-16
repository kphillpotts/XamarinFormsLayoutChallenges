using Formula1.Data;
using Formula1.Models;
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
            Race selectedRace = e.Item as Race;
            this.Navigation.PushAsync(new RaceDetailsPage(selectedRace));
        }

        ~RaceSchedulePage()
        {
            System.Diagnostics.Debug.WriteLine("Finishing RaceSchedulePage page");
        }

    }
}