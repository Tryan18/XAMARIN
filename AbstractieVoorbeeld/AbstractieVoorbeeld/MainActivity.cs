using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;
using Java.Lang;

namespace AbstractieVoorbeeld
{
	[Activity (Label = "AbstractieVoorbeeld", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		//Thread
		private System.Threading.Thread outputThread;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			//This method will activate the improved exceptionhandling
			ExceptionHandleUtil.GeneralExceptionHandler.SetGeneralExceptionHandler ();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			outputThread = new System.Threading.Thread (new ThreadStart (StartOutputThread));

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.btn_input);
			
			button.Click += delegate {
				outputThread.Start();
			};

			CreativeStaff cs = new CreativeStaff ();

			// assigning set property
			//cs.StaffNo = 5;
			// accessing get property
			//int getal = cs.StaffNo;

			TestExceptions();
		}

		public void StartOutputThread()
		{
			while(true)
			{
				RunOnUiThread (new Runnable (new Action (delegate {
					TextView textView_output = FindViewById<TextView>(Resource.Id.textView_output);
					textView_output.Text = count.ToString();
				})));
				count++;
				System.Threading.Thread.Sleep (1000);
			}
		}

		void TestExceptions ()
		{
			CreativeStaff cs = null;
			//Disable next statement for catching exception in try/catch block
			cs.calculateBonus();
			try
			{
				int a = 3;
				int b = 0;
				int resultaat = a / b;

				cs.calculateBonus();
			}
			//catch(NullReferenceException nrex)
			//{
			//	cs = new CreativeStaff ();
			//	//ShowException (nrex.ToString ());
			//}
			catch(System.Exception ex)
			{
				if(ex.GetType() == typeof(NullReferenceException))
				{

				}
				ShowException (ex.ToString ());
			}
			finally
			{
				
			}
		}

		public void ShowException(string ex)
		{
			TextView textView_output = FindViewById<TextView>(Resource.Id.textView_output);
			textView_output.Text = ex.ToString ();
		}
	}
}


