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
	public partial class RaceDetailsPage : ContentPage
	{
		public RaceDetailsPage ()
		{
			InitializeComponent ();
            this.BindingContext = DataRepository.MockRace;
        }


        public RaceDetailsPage(Race race)
        {
            InitializeComponent();
            this.BindingContext = race;
        }

    }
}