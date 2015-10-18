using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Reflection;

namespace PluginManager
{
	[Activity (Label = "PluginManager", MainLauncher = true, Icon = "@drawable/icon")]
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
				Assembly plugin = Assembly.LoadFile("/mnt/sdcard/Download/PluginA.dll");
				Type pluginType = plugin.GetType("PluginA.PluginA");
				object pluginInstance = Activator.CreateInstance(pluginType,new object[] { this });
				pluginType.InvokeMember("StartMessage",
						BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
					null, pluginInstance, new object[] { "woest" } );
			};
		}
	}
}

/*
 * [C#]
// dynamically load assembly from file Test.dll
Assembly testAssembly = Assembly.LoadFile(@"c:\Test.dll");

[C#]
// get type of class Calculator from just loaded assembly
Type calcType = testAssembly.GetType("Test.Calculator");

[C#]
// create instance of class Calculator
object calcInstance = Activator.CreateInstance(calcType);

[C#]
// get info about property: public double Number
PropertyInfo numberPropertyInfo = calcType.GetProperty("Number");

[C#]
// get value of property: public double Number
double value = (double)numberPropertyInfo.GetValue(calcInstance, null);

[C#]
// set value of property: public double Number
numberPropertyInfo.SetValue(calcInstance, 10.0, null);

[C#]
// get info about static property: public static double Pi
PropertyInfo piPropertyInfo = calcType.GetProperty("Pi");

[C#]
// get value of static property: public static double Pi
double piValue = (double)piPropertyInfo.GetValue(null, null);

[C#]
// invoke public instance method: public void Clear()
calcType.InvokeMember("Clear",
    BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
    null, calcInstance, null);

[C#]
// invoke private instance method: private void DoClear()
calcType.InvokeMember("DoClear",
    BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.NonPublic,
    null, calcInstance, null);

[C#]
// invoke public instance method: public double Add(double number)
double value = (double)calcType.InvokeMember("Add",
    BindingFlags.InvokeMethod | BindingFlags.Instance | BindingFlags.Public,
    null, calcInstance, new object[] { 20.0 });

[C#]
// invoke public static method: public static double GetPi()
double piValue = (double)calcType.InvokeMember("GetPi",
    BindingFlags.InvokeMethod | BindingFlags.Static | BindingFlags.Public,
    null, null, null);

[C#]
// get value of private field: private double _number
double value = (double)calcType.InvokeMember("_number",
    BindingFlags.GetField | BindingFlags.Instance | BindingFlags.NonPublic,
    null, calcInstance, null);
 * /


