using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossTest
{
	public partial class MyPage : ContentPage
	{
		public MyPage ()
		{
			InitializeComponent ();

			//Add your Code here!
		}

		void OnMainContentViewSizeChanged(object sender, EventArgs args)
		{

		}

		void OnBoardContentViewSizeChanged(object sender, EventArgs args)
		{

		}

		async void OnButtonClicked(object sender, EventArgs e)
		{
			await DisplayAlert ("Alert", "You have been alerted", "OK");
		}
	}
}

