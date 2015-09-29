using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;

namespace DrawExample
{
	[Activity (Label = "DrawExample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		Bitmap b = null;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Utils.Util.SetDisplayMetrics (Resources.DisplayMetrics);
			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btn_draw);
			ImageView iv = FindViewById<ImageView> (Resource.Id.imageView_output);
			button.Click += delegate {
				int width = Utils.Util.DetectScreenSize().Width;
				int height = Utils.Util.DetectScreenSize().Height;
				if(b != null)
				{
					iv.SetImageBitmap(null);
				}
				b = DrawImages.GetImage(width,height);
				iv.SetImageBitmap (b);
				b.Dispose();
			};
		}
	}
}


