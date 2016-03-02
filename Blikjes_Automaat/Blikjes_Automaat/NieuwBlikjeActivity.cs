
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

namespace Blikjes_Automaat
{
	[Activity (Label = "NieuwBlikjeActivity")]			
	public class NieuwBlikjeActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.NieuwBlikjeLayout);

			if (bundle == null) {
				Start ();
			}
		}

		void Start ()
		{
			//start code invoeren
		}
	}
}

