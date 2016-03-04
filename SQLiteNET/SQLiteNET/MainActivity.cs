using Android.App;
using Android.Widget;
using Android.OS;
using CC;

namespace SQLiteNET
{
	[Activity (Label = "SQLiteNET", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private ManagePersons mp = new ManagePersons();

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button btn_insert = FindViewById<Button> (Resource.Id.btn_insert);
			Button btn_getName = FindViewById<Button> (Resource.Id.btn_getName);
			Button btn_clear = FindViewById<Button> (Resource.Id.btn_clear);
			TextView textView_output = FindViewById<TextView> (Resource.Id.textView_output);
			
			btn_insert.Click += delegate 
			{
				mp.InsertPerson();
				Toast.MakeText(this.BaseContext,"Person Inserted",ToastLength.Short).Show();
			};

			btn_getName.Click += delegate 
			{
				textView_output.Text = "Name: " + mp.GetLastPersonName(); //(1);
			};

			btn_clear.Click += delegate 
			{
				mp.ClearDatabase();
				Toast.MakeText(this.BaseContext,"Database Cleared!",ToastLength.Short).Show();
			};
		}
	}
}


