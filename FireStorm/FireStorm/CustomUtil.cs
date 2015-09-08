using System;
using Android.Graphics;

namespace FireStorm
{
	public enum CustomShapeColor : int
	{
		Red,
		Green,
		White
	}

	public static class CustomUtil
	{
		private static Paint[] colors = null;
		public static Paint[] GetColors
		{
			get
			{
				if (colors == null) 
				{
					colors = SetColorShapes();
				}
				return colors;
			}
		}

		private static Paint[] SetColorShapes ()
		{
			//Enemy Color
			Paint red = new Paint();
			red.SetARGB(255, 255, 0, 0);
			red.SetStyle(Paint.Style.FillAndStroke);
			red.StrokeWidth = 1;

			//Player Color
			Paint green = new Paint();
			green.SetARGB(255, 0, 255, 0);
			green.SetStyle(Paint.Style.FillAndStroke);
			green.StrokeWidth = 1;

			//Background Color
			Paint white = new Paint();
			white.SetARGB(255, 255, 255, 255);
			white.SetStyle(Paint.Style.FillAndStroke);
			white.StrokeWidth = 1;

			return new Paint[] { red, green, white };
		}
	}
}

