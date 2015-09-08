using System;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Graphics;

namespace FireStorm
{

	public class CustomShape
	{
		Rect rect;
		Paint paint;
		int sizeShape;

		public Rect Rect {
			get {
				return rect;
			}
		}

		public Paint Paint {
			get {
				return paint;
			}
		}

		public CustomShape (int x,int y, int sizeShape,Paint paint)
		{
			this.sizeShape = sizeShape;
			this.paint = paint;
			this.rect = new Rect (x, y, sizeShape, sizeShape);
		}

		public void SetLocation(int i_x, int i_y, Direction current_direction)
		{
			int x = rect.Left;
			int y = rect.Top;
			switch (current_direction) 
			{
			case Direction.UpLeft:
				x -= i_x;
				y -= i_y;
					break;
			case Direction.UpRight:
				x += i_x;
				y -= i_y;
					break;
			case Direction.DownLeft:
				x -= i_x;
				y += i_y;
					break;
			case Direction.DownRight:
				x += i_x;
				y += i_y;
					break;
			}
			rect.Left = x;
			rect.Top = y;
			rect.Right = (x - sizeShape);
			rect.Bottom = (y - sizeShape);
		}
	}
}

