using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Robot
{
	[Activity (Label = "Robot", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			List<int> getallen = new List<int> ();
			getallen.Add (6);
			for (int i = 0; i < 10; i++) 
			{
				getallen.Add (i);
			}

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
			};

			TextView textview; //= FindViewById<TextView>(Reso
			textview.Text = Convert.ToString(getallen[0]);
			//button.Click +=	new EventHandler (ButtonClick);
		}
	}
}


