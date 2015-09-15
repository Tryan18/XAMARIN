using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace LayoutVoorbeeld
{
	[Activity (Label = "LayoutVoorbeeld", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btn_test);
			
			button.Click += delegate {
				
			};

			button.Click += new EventHandler (btn_test_click);
		}
		
		public void btn_test_click(object sender, EventArgs e)
		{
			StartActivity (typeof(TestActivity));
		}
	}
}


