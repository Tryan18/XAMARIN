
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
using Android.Graphics;
using Utils;

namespace BKE
{
	[Activity (Label = "BKE_Activity", Theme="@android:style/Theme.Black.NoTitleBar.Fullscreen")]			
	public class BKE_Activity : Activity
	{
		private CustomSize screen_size;
		private Bitmap background = null;
		private Canvas draw_canvas = null;
		private List<Blok> blokken;
		private Toestand current_toestand = Toestand.Circle;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.BKE_Layout);
			// Create your application here
			screen_size = Util.DetectScreenSize ();
			if (bundle == null) {
				Start ();
			}
		}

		void Start ()
		{
			LinearLayout LL = FindViewById<LinearLayout> (Resource.Id.ll_window);

			blokken = new List<Blok> ();

			int x = 0;
			int y = 0;
			int width = screen_size.Width / 3;
			int height = screen_size.Height / 3;

			for (int i = 0; i < 3; i++) 
			{
				for (int j = 0; j < 3; j++) 
				{
					blokken.Add (new Blok (x, y, width, height, Toestand.Unknown));
					x += width;
				}
				x = 0;
				y += height;
			}
			DrawBackground ();

			ImageView iv = FindViewById<ImageView> (Resource.Id.imageView_background);
			iv.SetImageBitmap (background);
			iv.Touch +=	OnTouch;
		}

		private void OnTouch(object sender, ImageView.TouchEventArgs e)
		{
			ImageView iv = (ImageView)sender;
			int x = Convert.ToInt32 (e.Event.GetX ());
			int y = Convert.ToInt32 (e.Event.GetY ());
			int total_clicked = 0;
			if (e.Event.Action == MotionEventActions.Up) 
			{
				foreach (Blok b in blokken) 
				{
					//Check om te weten op welk blokje is geklikt.
					//Werkt nog niet helemaal perfect.
					if (b.X <= x && x < (b.X + b.Width) && b.Y <= y && y < (b.Y + b.Height)) 
					{
						b.ClickBlok (current_toestand);
						//Short if statement in C#
						current_toestand = (current_toestand == Toestand.Circle) ? Toestand.Cross : Toestand.Circle;
					}
					total_clicked++;
				}
				DrawBackground ();
				iv.SetImageBitmap (background);
				if (Controle()) {
					Toast.MakeText (MainActivity.context, "Yeah, speler: " + current_toestand.ToString () + " heeft gewonnen!",ToastLength.Short);
				}
			}
		}

		//moet nog geimplementeerd worden.
		bool Controle ()
		{
			return false;
		}

		void DrawBackground ()
		{
			if (background != null) {
				background.Dispose ();
			}
			background = Bitmap.CreateBitmap(screen_size.Width, screen_size.Height, Bitmap.Config.Argb8888);
			Canvas c = new Canvas (background);
			//Paint black = new Paint();
			//black.SetARGB(255, 0, 0, 0);
			//black.SetStyle (Paint.Style.Stroke);
			//Bitmap plaatje = blokken[2].DrawBlok (MainActivity.context);

			//DrawBitmap werkt niet voor scaling bitmaps in xamarin
			//c.DrawBitmap (plaatje, new Rect (0, 0, plaatje.Width, plaatje.Height), new RectF (blokken[2].X, blokken[2].Y, blokken[2].Width, blokken[2].Height), null);
			//c.DrawBitmap(plaatje,96,0,null);

			foreach (Blok b in blokken) 
			{
				Bitmap plaatje = b.DrawBlok (MainActivity.context);
				c.DrawBitmap (plaatje, b.X, b.Y, null);
				plaatje.Dispose ();
			}
			c.Dispose ();
			//black.Dispose ();

		}
	}
}

