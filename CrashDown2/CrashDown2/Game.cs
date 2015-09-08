
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CrashDown2
{
	[Activity (Label = "Game")]			
	public class Game : Activity
	{
		private GameBlok[,] gameBloks;
		protected override void OnCreate (Bundle bundle)
		{
			if (bundle == null) {
				Initialize();
			}
			base.OnCreate (bundle);
		}

		private void Initialize()
		{
			const int rows = 10;
			const int columns = 10;
			gameBloks = new GameBlok[columns,rows];
			//Find Layout
			GridLayout gd_game = FindViewById<GridLayout> (Resource.Id.grid_game);
			for (int x = 0; x < columns; x++) {
				for (int y = 0; y < rows; y++) {
					gameBloks [x, y] = new GameBlok ();
				}
			}
		}
	}
}

