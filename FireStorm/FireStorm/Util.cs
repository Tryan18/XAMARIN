using System;
using Android.Util;
using Android.Content.Res;
using Android.Content;

namespace FireStorm
{
	public static class Util
	{
		private static DisplayMetrics displayMetrics;
		private static CustomSize cs = null;

		public static void SetDisplayMetrics(DisplayMetrics DisplayMetrics)
		{
			Util.displayMetrics = DisplayMetrics;
		}

		public static CustomSize DetectScreenSize ()
		{
			if (cs == null) 
			{
				DisplayMetrics metrics = displayMetrics;
				int width = ConvertPixelsToDp(metrics.WidthPixels);
				int height = ConvertPixelsToDp(metrics.HeightPixels);
				cs = new CustomSize(720,1280);
				//cs = new CustomSize(width,height);
			}
			return cs;
			//return new int[] { width, height };
		}

		private static int ConvertPixelsToDp(float pixelValue)
		{
			var dp = (int) ((pixelValue)/displayMetrics.Density);
			return dp;
		}
	}
}

