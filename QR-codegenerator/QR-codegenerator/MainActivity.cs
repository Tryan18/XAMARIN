using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ZXing;
using Android.Graphics;

namespace QRcodegenerator
{
	[Activity (Label = "QR-codegenerator", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			EditText editText_input = FindViewById<EditText> (Resource.Id.editText_input);
			ImageView imageView_output = FindViewById<ImageView> (Resource.Id.imageView_output);
			Button button = FindViewById<Button> (Resource.Id.btn_generate);
			
			button.Click += delegate
			{
				IBarcodeWriter writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE };
				var barcodeBitmap = writer.Write(editText_input.Text);
				imageView_output.SetImageBitmap(barcodeBitmap);
			};
		}
	}
}


