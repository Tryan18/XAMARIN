using System;
using Android.Widget;
using Android.Views;
using Android.Content;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

using DynamicViewAdder;

namespace DynamicViewAdder
{
	public class CustomView : RelativeLayout
	{
		private TextView title;
		private TextView description;
		private ImageView thumbnail;
		private ImageView icon;

		public CustomView(Context context)  : base (context)
		{
			init(context);
		}

		public CustomView(Context context, IAttributeSet attrs) : base(context, attrs)
		{
			init (context);
		}

		private void init(Context context) 
		{
			LayoutInflater inflater = (LayoutInflater)context.GetSystemService (Context.LayoutInflaterService);
			View view = inflater.Inflate (Resource.Layout.customview, this);
			//Inflate(context, Resource.Layout.customview, this);
			this.title = (TextView)view.FindViewById(Resource.Id.title);
			this.description = (TextView)view.FindViewById(Resource.Id.description);
			this.thumbnail = (ImageView)view.FindViewById(Resource.Id.thumbnail);
			this.icon = (ImageView)view.FindViewById(Resource.Id.icon);
		}
	}
}

