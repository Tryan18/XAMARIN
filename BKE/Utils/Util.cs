using System;
using Android.Util;
using Android.Graphics;

namespace Utils
{
	public static class Util
	{
		private static DisplayMetrics displayMetrics;
		private static CustomSize cs = null;

		public static void SetDisplayMetrics(DisplayMetrics DisplayMetrics)
		{
			Util.displayMetrics = DisplayMetrics;
		}

		//For DetectScreenSize method to work properly SetDisplayMetrics method must be first called
		public static CustomSize DetectScreenSize ()
		{
			if (cs == null) 
			{
				DisplayMetrics metrics = displayMetrics;
				int width = metrics.WidthPixels;//ConvertPixelsToDp(metrics.WidthPixels);
				int height = metrics.HeightPixels;//ConvertPixelsToDp(metrics.HeightPixels);
				//cs = new CustomSize(720,1280);
				cs = new CustomSize(width,height);
			}
			return cs;
			//return new int[] { width, height };
		}

		public static int ConvertPixelsToDp(float pixelValue)
		{
			var dp = (int) ((pixelValue)/displayMetrics.Density);
			return dp;
		}

		public static Bitmap ScaleDownBitmap(Bitmap originalImage, float maxImageSize, bool filter)
		{
			float ratio = Math.Min((float)maxImageSize / originalImage.Width, (float)maxImageSize / originalImage.Height);
			int width = (int)Math.Round(ratio * (float)originalImage.Width);
			int height =(int) Math.Round(ratio * (float)originalImage.Height);

			Bitmap newBitmap = Bitmap.CreateScaledBitmap(originalImage, width, height, filter);
			return newBitmap;
		}

		public static Bitmap ScaleUpBitmap(Bitmap originalImage, int wantedWidth, int wantedHeight)
		{
			Bitmap output = Bitmap.CreateBitmap(wantedWidth, wantedHeight, Bitmap.Config.Argb8888);
			Canvas canvas = new Canvas(output);
			Matrix m = new Matrix();
			m.SetScale((float)wantedWidth / originalImage.Width, (float)wantedHeight / originalImage.Height);
			canvas.DrawBitmap(originalImage, m, new Paint());
			canvas.Dispose ();
			originalImage.Dispose ();
			return output;
		}
	}
}

