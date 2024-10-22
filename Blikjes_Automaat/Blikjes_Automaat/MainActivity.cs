﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Blikjes_Automaat
{
	[Activity (Label = "Blikjes_Automaat", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btn_nieuw = FindViewById<Button> (Resource.Id.btn_nieuw);
			
			btn_nieuw.Click += delegate {
				StartActivity(typeof(NieuwBlikjeActivity));
			};
		}
	}
}


