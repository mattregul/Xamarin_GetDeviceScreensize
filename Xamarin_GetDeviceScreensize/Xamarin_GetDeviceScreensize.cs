using System;

using Xamarin.Forms;

namespace Xamarin_GetDeviceScreensize
{
	public class App : Application
	{
		public static double DisplayScreenWidth;
		public static double DisplayScreenHeight;
		public static double DisplayScaleFactor;

		public App()
		{
			
			string ScreenDetails =	Device.OS.ToString() + " Device Screen Size:\n" +
				      				$"Width: {DisplayScreenWidth}\n" +
				      				$"Height: {DisplayScreenHeight}\n" +
					  				$"Scale Factor: {DisplayScaleFactor}";
			
			// The root page of your application
			var content = new ContentPage
			{
				Title = "Xamarin_GetDeviceScreensize",
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label)),
							Text = ScreenDetails
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

	}
}
