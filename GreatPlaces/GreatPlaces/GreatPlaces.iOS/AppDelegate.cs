using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using ImageCircle.Forms.Plugin.iOS;
using UIKit;

namespace GreatPlaces.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			//UINavigationBar.Appearance.BackgroundColor = UIColor.Black;
			//UINavigationBar.Appearance.BarTintColor = UIColor.Black;
			//UINavigationBar.Appearance.TintColor = UIColor.FromRGB(62, 56, 121);
			//UINavigationBar.Appearance.SetTitleTextAttributes(
			//	new UITextAttributes()
			//	{
			//		TextColor = UIColor.FromRGB(62, 56, 121),
			//		Font = UIFont.FromName("AvenirNext-Bold", 20f)
			//	});

			//UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.LightContent, false);


            global::Xamarin.Forms.Forms.Init();
			ImageCircleRenderer.Init();
            LoadApplication(new App());
			//UIApplication.SharedApplication.StatusBarHidden = true;
			//UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.LightContent;
			//UIApplication.SharedApplication.SetStatusBarStyle(UIStatusBarStyle.BlackOpaque, true);
            return base.FinishedLaunching(app, options);
        }
    }
}
