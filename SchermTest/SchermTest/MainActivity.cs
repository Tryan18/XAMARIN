using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace SchermTest
{
	[Activity (Label = "SchermTest", MainLauncher = true, Icon = "@drawable/icon")]
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
			Button button = FindViewById<Button> (Resource.Id.btn_enter);
			EditText textView = FindViewById<EditText> (Resource.Id.EditText_input);

			Button btn_StartActivity = FindViewById<Button> (Resource.Id.btn_StartActivity);

			btn_StartActivity.Click += delegate
			{
				StartActivity(typeof(TestActivity));
			};

			//button.Click += EventHandler;
			button.Click += delegate
			{
				Toast.MakeText(this.BaseContext,textView.Text,ToastLength.Short).Show();

				//button.Text = string.Format ("{0} clicks!", count++);
			};
		}

		public void EventHandler(object sender, EventArgs e)
		{
			
		}

		protected override void OnStart()
		{
			base.OnStart ();
		}
	}
}


