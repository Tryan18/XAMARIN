using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Robot_stratenplan
{
	[Activity (Label = "Robot_stratenplan", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		private Stratenplan stratenplan;
		private Robot robot;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			stratenplan = new Stratenplan ();
			robot = new Robot (stratenplan);
			// Get our button from the layout resource,
			// and attach an event to it
			Button btn_voorwaarts = FindViewById<Button> (Resource.Id.btn_voorwaarts);
			
			btn_voorwaarts.Click += delegate {
				
			};

			Button btn_linksom = FindViewById<Button> (Resource.Id.btn_linksom);

			btn_linksom.Click += delegate {

			};

			TextView tv_stratenplan_output = FindViewById<TextView> (Resource.Id.tv_stratenplan_output);
			tv_stratenplan_output.Text = stratenplan.ShowPlan ();


		}
	}
}


