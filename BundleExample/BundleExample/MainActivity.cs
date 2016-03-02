using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BundleExample
{
	[Activity (Label = "BundleExample", MainLauncher = true, Icon = "@drawable/icon")]
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
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				Intent activity2Intent = new Intent(this,typeof(Activity2));
				Bundle b = new Bundle();
				b.PutString("key"," test");
				activity2Intent.PutExtras(b);
				StartActivity(activity2Intent);
			};
		}
	}
}


