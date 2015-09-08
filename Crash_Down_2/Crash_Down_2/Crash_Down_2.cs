using System;

using Xamarin.Forms;

namespace Crash_Down_2
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						}
					}
				}
			};
		}

//		protected override void OnCreate(Bundle bundle)
//		{
//			base.OnCreate(bundle);
//
//			string extraString;
//			bool extraBool;
//
//			if (bundle != null)
//			{
//				intentString = bundle.GetString("myString");
//				intentBool = bundle.GetBoolean("myBool");
//			}
//
//			// Set our view from the "main" layout resource
//			SetContentView(Resource.Layout.Main);
//		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

