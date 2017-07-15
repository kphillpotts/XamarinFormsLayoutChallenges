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
	public partial class MenuPage : ContentPage
	{
        public ListView ListView { get { return menuListView; } }

        public MenuPage ()
		{
			InitializeComponent ();

            var menuPageItems = new List<MenuPageItem>();
            menuPageItems.Add(new MenuPageItem
            {
                Title = "Driver Rankings",
                IconSource = "Trophy_Black.png",
                TargetType = typeof(DriverRankingsPage)
            });
            menuPageItems.Add(new MenuPageItem
            {
                Title = "Race Schedule",
                IconSource = "Calendar_Black.png",
                TargetType = typeof(RaceSchedulePage)
            });

            menuListView.ItemsSource = menuPageItems;

        }
	}


    public class MenuPageItem
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Type TargetType { get; set; }
    }
}