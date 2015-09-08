using System;
using Android.Graphics;
using Android.Util;
using Java.Lang;

namespace FireStorm
{
	public enum Direction
	{
		UpLeft,
		DownLeft,
		UpRight,
		DownRight
	}

	public class Enemy : CustomShape
	{
		private Runnable moveThread;
		CustomSize screen_size = Util.DetectScreenSize();
		Direction current_direction;

		public Enemy (int x, int y, int sizeShape, Paint paint, Direction current_direction) : base(x,y,sizeShape,paint)
		{
			this.current_direction = current_direction;
			moveThread = new Runnable (new Action (delegate {
				while(true)
				{
					SetLocation (5, 5, current_direction);
					CheckBounds ();
					//Shape.Draw (Battlefield.Draw_canvas);
					Thread.Sleep(500);
				}
			}));
		}

		void CheckBounds ()
		{
			Rect rec = this.Rect;
			if (rec.Bottom > screen_size.Height)
			{
				if (current_direction == Direction.DownLeft)
					current_direction = Direction.UpLeft;
				else
					current_direction = Direction.UpRight;
			} else if (rec.Left < 0) {
				if (current_direction == Direction.DownLeft)
					current_direction = Direction.DownRight;
				else
					current_direction = Direction.UpRight;
			} else if (rec.Top < 0) {
				if (current_direction == Direction.UpLeft)
					current_direction = Direction.DownLeft;
				else
					current_direction = Direction.DownRight;
			} else if (rec.Right > screen_size.Width) {
				if(current_direction == Direction.DownRight)
					current_direction = Direction.DownLeft;
				else
					current_direction = Direction.UpLeft;
			}
		}

		public void Start()
		{
			new Thread (moveThread).Start ();
		}
	}
}

