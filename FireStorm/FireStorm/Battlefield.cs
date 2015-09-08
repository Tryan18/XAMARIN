
using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Util;

namespace FireStorm
{
	public class Battlefield
	{
		private List<Enemy> enemies = new List<Enemy>();
		private Player player;
		private const int enemy_count = 50;
		private CustomSize screen_size;
		private readonly int sizeShape = 5;
		private Random r;
		private Bitmap background;
		private static Canvas draw_canvas;

		public static Canvas Draw_canvas {
			get {
				return draw_canvas;
			}
		}

		public Bitmap Background {
			get {
				return background;
			}
		}

		public Battlefield()
		{
			r = new Random();
			screen_size = Util.DetectScreenSize();
			Paint p = CustomUtil.GetColors [(int)CustomShapeColor.Green];
			player = new Player(screen_size.Width / 2, screen_size.Height / 2, sizeShape, p);
			CreateEnemies();

			background = Bitmap.CreateBitmap(screen_size.Width, screen_size.Height, Bitmap.Config.Argb8888);
			draw_canvas = new Canvas (background);
		}
			
		public void Start()
		{
			foreach (Enemy e in enemies) {
				e.Start ();
			}
		}

		void CreateEnemies ()
		{
			for (int i = 0; i < enemy_count; i++)
			{
				enemies.Add (new Enemy (r.Next(0,screen_size.Width), r.Next(0,screen_size.Height), sizeShape, CustomUtil.GetColors[(int)CustomShapeColor.Red],Direction.DownRight));
			}
		}

		public void Draw()
		{
			//background = Bitmap.CreateBitmap(screen_size.Width, screen_size.Height, Bitmap.Config.Argb8888);
			//draw_canvas = new Canvas (background);
			//draw background
			draw_canvas.DrawRect (new Rect (0, 0, screen_size.Width, screen_size.Height), CustomUtil.GetColors [(int)CustomShapeColor.White]);
			//draw enemies
			foreach(Enemy e in enemies)
			{
				draw_canvas.DrawRect(e.Rect, e.Paint);
			}
		}
	}
}

