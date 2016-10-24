using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace Xamarin_GetDeviceScreensize.Droid
{
	[Activity(Label = "Xamarin_GetDeviceScreensize.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			// Store off the device sizes, so we can access them within Xamarin Forms
			App.DisplayScreenWidth 	= (double)Resources.DisplayMetrics.WidthPixels	/ (double)Resources.DisplayMetrics.Density; // Width = WidthPixels / Density
			App.DisplayScreenHeight	= (double)Resources.DisplayMetrics.HeightPixels	/ (double)Resources.DisplayMetrics.Density; // Height = HeightPixels / Density
			App.DisplayScaleFactor	= (double)Resources.DisplayMetrics.Density;

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App());
		}
	}
}
