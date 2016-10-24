using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Xamarin_GetDeviceScreensize.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			// Store off the device sizes, so we can access them within Xamarin Forms
			App.DisplayScreenWidth	= (double)UIScreen.MainScreen.Bounds.Width;
			App.DisplayScreenHeight	= (double)UIScreen.MainScreen.Bounds.Height;
			App.DisplayScaleFactor	= (double)UIScreen.MainScreen.Scale;

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
