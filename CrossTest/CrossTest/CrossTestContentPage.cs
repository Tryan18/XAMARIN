using System;

using Xamarin.Forms;

namespace CrossTest
{
	public class CrossTestContentPage : ContentPage
	{
		public CrossTestContentPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


