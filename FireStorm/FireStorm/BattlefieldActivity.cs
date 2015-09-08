
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
using Java.Lang;

namespace FireStorm
{
	[Activity (Label = "BattlefieldActivity")]
	public class BattlefieldActivity : Activity
	{
		Battlefield bf;
		private Runnable drawThread;
		private Runnable uiThread;
		private Runnable bitmapThread;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			if (bundle == null) 
			{
				SetContentView (Resource.Layout.BattlefieldActivityLayout);
				bf = new Battlefield ();
				uiThread = new Runnable (new Action (delegate {
					while(true)
					{
						RunOnUiThread (drawThread);
						Thread.Sleep(500);
					}
				}));
				bitmapThread = new Runnable (new Action (delegate {
					while(true)
					{
						bf.Draw();
						Thread.Sleep(500);
					}
					//ImageView iv = FindViewById<ImageView> (Resource.Id.imageViewBattlefield);
					//iv.Invalidate();
				}));
				drawThread = new Runnable (new Action (delegate {
					//bf.Draw();
					ImageView iv = FindViewById<ImageView> (Resource.Id.imageViewBattlefield);
					iv.Invalidate();
				}));
			}
		}

		protected override void OnStart()
		{
			base.OnStart ();
			ImageView iv = FindViewById<ImageView> (Resource.Id.imageViewBattlefield);
			iv.SetImageBitmap (bf.Background);
			bf.Start();
			//RunOnUiThread (drawThread);
			new Thread (uiThread).Start ();
			new Thread (bitmapThread).Start ();
		}
	}
}

