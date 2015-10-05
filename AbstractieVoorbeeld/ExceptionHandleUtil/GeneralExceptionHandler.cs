using System;
using Android.Runtime;

namespace ExceptionHandleUtil
{
	/* This class helps when the developer is constant receiving a Java.runtime exception with no concrete direction of where the the exception is triggered.
	 */
	public static class GeneralExceptionHandler
	{
		public static void SetGeneralExceptionHandler()
		{
			AndroidEnvironment.UnhandledExceptionRaiser +=  HandleUnhandledException;
		}

		static void HandleUnhandledException (object sender, RaiseThrowableEventArgs e)
		{
			e.Handled = true;
			throw e.Exception;
		}
	}
}

