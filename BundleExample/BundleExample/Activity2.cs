
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BundleExample
{
	[Activity (Label = "Activity2")]			
	public class Activity2 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
			if(bundle != null)
			{
				
				string s = bundle.GetString ("key");
			}
			string ss = Intent.GetStringExtra ("key");
		}
	}
}

