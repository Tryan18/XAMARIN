using System;

namespace FireStorm
{
	public class CustomSize
	{
		private int width,height;

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

		public CustomSize (int width, int height)
		{
			this.width = width;
			this.height = height;
		}
	}
}

