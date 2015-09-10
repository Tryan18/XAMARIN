using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Auto
{
	[Activity (Label = "Auto", MainLauncher = true, Icon = "@drawable/icon")]
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
				button.Text = string.Format ("{0} clicks!", count++);
			};

			BMW bmw = new BMW ();
			bmw.Rij ();

			AUDI audi = new AUDI ();
			audi.Parkeren ();

			List<Auto> autos = new List<Auto> ();
			autos.Add (bmw);
			autos.Add (audi);

			//Polymorphism
			foreach (Auto a in autos) {
				a.Rij ();
			}
		}
	}
}


