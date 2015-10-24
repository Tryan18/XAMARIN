using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics;
using System.Net;
using Java.IO;

namespace BitmapExample
{
	[Activity (Label = "BitmapExample", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
			
			button.Click += delegate {
				
				//Get image bitmap from url
				Bitmap imageBitmap = GetImageBitmapFromUrl("http://xamarin.com/content/images/pages/platform/sketches-screenshot.png");

				ImageView image = FindViewById<ImageView>(Resource.Id.imageView1);


				//Save Image to internal storage
				ContextWrapper cw = new ContextWrapper(this.ApplicationContext);
				File directory = cw.GetDir("imgDir", FileCreationMode.Private);
				File myPath = new File(directory, "test.png");
				try 
				{
					using (var os = new System.IO.FileStream(myPath.AbsolutePath, System.IO.FileMode.Create))
					{
						imageBitmap.Compress(Bitmap.CompressFormat.Png, 100, os);
					}
				}
				catch (Exception ex) 
				{
					System.Console.Write(ex.Message);
				}

				//Load Image from internal storage
				Bitmap loadedImage = BitmapFactory.DecodeFile(myPath.AbsoluteFile.AbsolutePath);
				image.SetImageBitmap(loadedImage);
			};
		}

		private Bitmap GetImageBitmapFromUrl(string url)
		{
			Bitmap imageBitmap = null;

			using (var webClient = new WebClient())
			{
				var imageBytes = webClient.DownloadData(url);
				if (imageBytes != null && imageBytes.Length > 0)
				{
					imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
				}
			}

			return imageBitmap;
		}
	}
}


