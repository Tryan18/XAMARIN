using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Utils;

namespace BKE
{
	[Activity (Label = "BKE", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		public static Context context;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			context = this.BaseContext;
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Util.SetDisplayMetrics (Resources.DisplayMetrics);
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btn_start);
			
			button.Click += delegate {
				StartActivity(typeof(BKE_Activity));
			};
		}
	}
}


