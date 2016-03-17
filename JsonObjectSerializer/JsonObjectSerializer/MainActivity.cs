using Android.App;
using Android.Widget;
using Android.Graphics;
using Newtonsoft.Json;
using System.IO;
using System;
using Android.OS;

namespace JsonObjectSerializer
{
	[Activity (Label = "JsonObjectSerializer", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private JsonSerializerSettings json_settings = null;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btn_save = FindViewById<Button> (Resource.Id.btn_save);
			Button btn_load = FindViewById<Button> (Resource.Id.btn_load);
			TextView textView_output = FindViewById<TextView> (Resource.Id.textView_output);
			
			btn_save.Click += delegate {
				CreateJsonObject();
				Toast.MakeText(this.BaseContext,"Saving Json!",ToastLength.Short).Show();
			};
				
			btn_load.Click += delegate {
				textView_output.Text = LoadJsonObject();
				Toast.MakeText(this.BaseContext,"Loading Json!",ToastLength.Short).Show();
			};

			Initialize ();
		}

		private void Initialize()
		{
			if(json_settings == null)
			{
				json_settings = new JsonSerializerSettings ();
				json_settings.ContractResolver = new MyContractResolver();
			}
		}

		private void CreateJsonObject()
		{
			//Example object for JSON serialization
			GameBlock gb = new GameBlock ();
			gb.GameblockNr = 3;
			gb.IsDeleted = true;
			gb.Kolom = 10;
			gb.Rij = 5;
			gb.X = 100;
			gb.Y = 100;
			gb.Background = Bitmap.CreateBitmap (100, 100, Bitmap.Config.Argb8888);

			string json = JsonConvert.SerializeObject (gb,Formatting.Indented,json_settings);

			SaveText (json);
		}

		private string LoadJsonObject()
		{
			string json = LoadText ();
			if (json.Length > 0) 
			{
				GameBlock gb = JsonConvert.DeserializeObject<GameBlock> (json);
				Console.WriteLine ("GameblockNr: " + gb.GameblockNr.ToString ());
			}
			return json;
		}

		private void SaveText(string input)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string filename = System.IO.Path.Combine(path, "json_gb.txt");

			if (File.Exists (filename))
				File.Delete (filename);

			using (var streamWriter = new StreamWriter(filename, true))
			{
				streamWriter.Write(input);
			}
			}

		private string LoadText()
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			string filename = System.IO.Path.Combine(path, "json_gb.txt");
			string output = "";

			if (!File.Exists (filename))
				return output;

			using (var streamReader = new StreamReader(filename))
			{
				output = streamReader.ReadToEnd();
			}

			return output;
		}
	}
}


