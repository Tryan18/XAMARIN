using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AddAdvert
{
	[Activity (Label = "AddAdvertUI", MainLauncher = true, Icon = "@drawable/icon")]
	public class AddAdvertUI : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			CC_AddAdvert.CC_AddAdvert AddAdvert = new CC_AddAdvert.CC_AddAdvert ();

			button.Click += delegate {
				AddAdvert.Test();
			};

			AddAdvert.ActieGebeurtenis += TestActie;
		}

		public void TestActie(string test)
		{
			Toast.MakeText (this.BaseContext, test, ToastLength.Short);
		}
	}
}


