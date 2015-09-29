using System;
using Android.Graphics;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DrawExample
{
	public static class DrawImages
	{
		static DrawImages ()
		{
			
		}

		private static string intensity = "FF";
		private static int fileCounter = 0;
		private static List<Bitmap> blocks = null;
		private static int sizeBlocks = 10;
		private static Random r = null;
		private static string[] colourValues = new string[] { 
			"FF0000", "00FF00", "0000FF", "FFFF00", "FF00FF", "00FFFF", "000000", 
			"800000", "008000", "000080", "808000", "800080", "008080", "808080", 
			"C00000", "00C000", "0000C0", "C0C000", "C000C0", "00C0C0", "C0C0C0", 
			"400000", "004000", "000040", "404000", "400040", "004040", "404040", 
			"200000", "002000", "000020", "202000", "200020", "002020", "202020", 
			"600000", "006000", "000060", "606000", "600060", "006060", "606060", 
			"A00000", "00A000", "0000A0", "A0A000", "A000A0", "00A0A0", "A0A0A0", 
			"E00000", "00E000", "0000E0", "E0E000", "E000E0", "00E0E0", "E0E0E0", 
		};

		public static Bitmap GetImage(int width, int height)
		{
			
			sizeBlocks = width / 7;
			int amountImages = 56;
			List<Bitmap> bitmaps = DrawImages.CreateBitmapBlocks (amountImages, false);
			Paint p = new Paint ();
			p.StrokeWidth = 0.5f;
			p.SetStyle (Paint.Style.Fill);
			p.Color = Color.White;
			Bitmap b = Bitmap.CreateBitmap (width, height, Bitmap.Config.Argb8888);
			Canvas c = new Canvas (b);
			//Make background White
			c.DrawRect (new Rect (0, 0, width, height), p);
			//Draw Blocks
			for(int i=0;i<amountImages;i++)
			{
				c.DrawBitmap (bitmaps[i], (i % 7) * (width / 7), (i % 8) * (height / 8), p);
			}
			p.Dispose ();
			c.Dispose ();
			return b;
		}

		private static List<Bitmap> CreateBitmapBlocks(int amount,bool random_colors)
		{
			if (blocks != null) {
				foreach(Bitmap b in blocks)
				{
					b.Dispose ();
				}
			}
				blocks = new List<Bitmap> ();
				List<Color[]> colors = null;
				if(random_colors)
					colors = CreateRandomColors (amount);
				else
					colors = CreateStaticColors (amount);
				for (int i = 0; i < amount; i++) 
				{
				Bitmap b = Bitmap.CreateBitmap (sizeBlocks, sizeBlocks, Bitmap.Config.Argb8888);
					using (Canvas c = new Canvas (b)) 
					{
						int x, y, w, h;
						x = Convert.ToInt32 (sizeBlocks * 0.1f);
						y = Convert.ToInt32 (sizeBlocks * 0.1f);
						w = Convert.ToInt32 (sizeBlocks * 0.9f);
						h = Convert.ToInt32 (sizeBlocks * 0.9f);
						//First fill up the bitmap with background color
						DrawAndPaint (c, new Rect (x,y,w,h), Paint.Style.Fill, 0.5f, colors [i] [0]);
						//Then draw black border around it
						DrawAndPaint (c, new Rect (x,y,w,h), Paint.Style.Stroke, 0.5f, Color.Black);
						x = Convert.ToInt32 (sizeBlocks * 0.3f);
						y = Convert.ToInt32 (sizeBlocks * 0.3f);
						w = Convert.ToInt32 (sizeBlocks * 0.7f);
						h = Convert.ToInt32 (sizeBlocks * 0.7f);
						//Then fill inner block background
						DrawAndPaint (c, new Rect (x,y,w,h), Paint.Style.Fill, 0.5f, colors [i] [1]);
						//Then draw inner black border around it
						DrawAndPaint (c, new Rect (x,y,w,h), Paint.Style.Stroke, 0.5f, Color.Black);
						//For Debug
						//ExportBitmapAsPNG (b);
						blocks.Add (b);
					}
				}
				return blocks;
		}

		private static void DrawAndPaint(Canvas c,Rect rec, Paint.Style paintStyle, float strokeWidth, Color color)
		{
			using (Paint p = new Paint ()) 
			{
				p.AntiAlias = true;
				p.Dither = true;
				p.SetStyle (paintStyle);
				p.StrokeWidth = strokeWidth;
				p.Color = color;
				c.DrawRect (rec, p);
			}
		}

		private static void ExportBitmapAsPNG(Bitmap bitmap)
		{
			var sdCardPath = Android.OS.Environment.ExternalStorageDirectory.AbsolutePath;
			var filePath = System.IO.Path.Combine(sdCardPath, "test"+fileCounter.ToString()+".png");
			var stream = new FileStream(filePath, FileMode.Create);
			bitmap.Compress(Bitmap.CompressFormat.Png, 100, stream);
			stream.Close();
			fileCounter++;
		}

		private static List<Color[]> CreateRandomColors(int amount)
		{
			List<Color[]> colors = new List<Color[]>();
			r = new Random (DateTime.Now.Millisecond);
			for (int i = 0; i < amount; i++) {
				Color big = new Color (r.Next (0, 256), r.Next (0, 256), r.Next (0, 256));
				Color small = new Color (r.Next (0, 256), r.Next (0, 256), r.Next (0, 256));
				Color[] temp = new Color[] { big, small };
				colors.Add (temp);
			}
			return colors;
		}

		private static List<Color[]> CreateStaticColors(int amount)
		{
			List<Color[]> colors = new List<Color[]> ();
			for (int i = 0; i < amount; i++) 
			{
				Color[] temp;
				if(i+1== amount)
					temp = new Color[] { ConvertColor(colourValues [i]), ConvertColor(colourValues [i - 1]) };
				else
				    temp = new Color[] { ConvertColor(colourValues [i]), ConvertColor(colourValues [i + 1]) };
				colors.Add (temp);
			}
			return colors;
		}

		/*
		private static Color ConvertColor(string hex)
		{
			int r = Int32.Parse (hex.Substring(0,2), NumberStyles.HexNumber);
			int g = Int32.Parse (hex.Substring(2,2), NumberStyles.HexNumber);
			int b = Int32.Parse (hex.Substring(4,2), NumberStyles.HexNumber);
			return new Color (r, g, b);
		}*/

		private static Color ConvertColor(string hex)
		{
			int argb = Int32.Parse(intensity+hex ,NumberStyles.HexNumber);
			return new Color (argb);
		}
	}
}

