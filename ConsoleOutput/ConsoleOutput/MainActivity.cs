using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ConsoleOutput
{
	[Activity (Label = "ConsoleOutput", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private Robot robot = null;

		void Start ()
		{
			robot = new Robot (10, 0);

			Button button = FindViewById<Button> (Resource.Id.btn_enter);
			button.Click += new EventHandler(btn_enter_click);

			EditText num_input = FindViewById<EditText> (Resource.Id.num_input);
			

			Button btn_ganaar = FindViewById<Button> (Resource.Id.btn_ganaar);
			btn_ganaar.Click += delegate {
				robot.gaNaar (Convert.ToInt32(num_input.Text));
			};

			Button btn_zetEenStap = FindViewById<Button> (Resource.Id.btn_zetEenStap);
			btn_zetEenStap.Click += delegate {
				robot.zetEenStap();
			};
			
		}

		private void btn_enter_click(object sender, EventArgs e)
		{
			TextView tv = FindViewById<TextView> (Resource.Id.tv_output);
			tv.Text = robot.print ();
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			if (bundle == null) {
				Start ();
			}
			// Get our button from the layout resource,
			// and attach an event to it


			//Button Click Event
			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			//};

		}
	}
}


