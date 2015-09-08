
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

namespace BKE
{
	[Activity (Label = "BKE_Activity")]			
	public class BKE_Activity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.BKE_Layout);
			// Create your application here
			if (bundle == null) {
				Start ();
			}
		}

		void Start ()
		{
			
			int id = this.getResources().getIdentifier("gameover", "drawable", getPackageName());
			ImageView imageView = new ImageView(this);
			LinearLayout.LayoutParams vp = 
				new LinearLayout.LayoutParams(LayoutParams.WRAP_CONTENT, 
					LayoutParams.WRAP_CONTENT);
			imageView.setLayoutParams(vp);        
			imageView.setImageResource(id);        
			someLinearLayout.addView(imageView); 
		}
	}
}

