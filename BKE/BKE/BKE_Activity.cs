
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
		private CustomSize screen_size = Util.DetectScreenSize ();

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
			LinearLayout LL = FindViewById<LinearLayout> (Resource.Id.ll_window);

			//int x = 0;
			//int y = 0;
			int width = screen_size.Width / 3;
			int height = screen_size.Height / 3;

			for (int i = 0; i < 3; i++) 
			{
				for (int j = 0; j < 3; j++) 
				{
					int id = Resources.GetIdentifier ("blue_circle", "drawable", this.PackageName);
					ImageView imageView = new ImageView (this);
					FrameLayout.LayoutParams vglp = new FrameLayout.LayoutParams(width,height);
					//vglp.LeftMargin = j * width;
					//vglp.TopMargin = i * height;
					//vglp.SetMargins (j * width, i * height, 0, 0);
					imageView.SetScaleType (ImageView.ScaleType.FitXy);
					imageView.LayoutParameters = vglp; 
					imageView.SetImageResource (id); 


					LL.AddView (imageView);
					//x += width;
				}
				//x = 0;
				//y += height;
			}
		}
	}
}

