using System;
using Newtonsoft.Json;
using Android.Graphics;

namespace JsonObjectSerializer
{
	public enum GameBlockType : int
	{
		Normal,
		Ammo,
		Score
	}

	public class GameBlock
	{
		private GameBlockType gameBlockType;

		[JsonIgnore]
		private Bitmap background;

		[JsonIgnore]
		public Bitmap Background {
			get {
				return background;
			}
			set {
				background = value;
			}
		}

		public bool IsDeleted { get; set; }
		public int GameblockNr { get; set; }
		public int X { get; set; } 
		public int Y { get; set; }
		public int Rij { get; set; }
		public int Kolom { get; set; }

		//Default Constructor
		public GameBlock()
		{

		}
	}
}

