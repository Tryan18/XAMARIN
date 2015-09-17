using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace DynamicViewAdder
{
	[Activity (Label = "DynamicViewAdder", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 2;
		List<Button> buttons = new List<Button>();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			LinearLayout LL_main = FindViewById<LinearLayout> (Resource.Id.LL_main);

			Button btn_add = FindViewById<Button> (Resource.Id.btn_add);
			
			btn_add.Click += delegate {
				Button b = new Button(this);
				b.Text = "Button " +count.ToString();
				buttons.Add(b);
				LL_main.AddView(b);
				count++;
			};

			Button btn_remove = FindViewById<Button> (Resource.Id.btn_remove);

			btn_remove.Click += delegate {	
				if(count>2)
				{
					Button b = buttons[buttons.Count-1];
					LL_main.RemoveView(b);
					buttons.Remove(b);
					count--;
				}
			};
		}
	}
}


