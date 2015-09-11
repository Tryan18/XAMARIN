using System;
using Android.Graphics;
using Android.Content;
using Android.Graphics.Drawables;

namespace BKE
{
	public enum Toestand
	{
		Circle,
		Cross,
		Unknown
	}

	public class Blok
	{
		private int x,y,width,height;
		private Toestand toestand;
		private bool clicked = false;

		public int X {
			get {
				return x;
			}
		}

		public int Y {
			get {
				return y;
			}
		}

		public int Width {
			get {
				return width;
			}
		}

		public int Height {
			get {
				return height;
			}
		}

		public Blok (int x, int y, int width, int height, Toestand toestand)
		{
			this.x = x;
			this.y = y;
			this.width = width;
			this.height = height;
			this.toestand = toestand;
		}

		public Bitmap DrawBlok (Context context)
		{
			Bitmap plaatje = null;
			switch (toestand) 
			{
			case Toestand.Circle:
				
				plaatje = ((BitmapDrawable)context.Resources.GetDrawable (Resource.Drawable.blue_circle)).Bitmap;
					break;
				case Toestand.Cross:
				plaatje = ((BitmapDrawable)context.Resources.GetDrawable (Resource.Drawable.red_x)).Bitmap;
					break;
			case Toestand.Unknown:
				plaatje = ((BitmapDrawable)context.Resources.GetDrawable (Resource.Drawable.Icon)).Bitmap;
					break;
			}
			return Util.ScaleUpBitmap (plaatje, width, height);;
		}

		public void ClickBlok (Toestand current_toestand)
		{
			clicked = true;
			toestand = current_toestand;
		}
	}
}

