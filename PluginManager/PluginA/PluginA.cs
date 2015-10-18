using System;
using Android.App;
using Android.Widget;

namespace PluginA
{
	public class PluginA
	{
		private Activity ga;
		private string text;

		public PluginA (Activity genericActivity)
		{
			ga = genericActivity;
		}

		public void StartMessage(string text)
		{
			this.text = text;
			ga.RunOnUiThread (ShowToastMessageBox);
		}

		private void ShowToastMessageBox()
		{
			Toast.MakeText (ga, "Tada, Plugin works!: "+text, ToastLength.Short).Show();
		}
	}
}

