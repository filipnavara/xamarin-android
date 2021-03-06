using System;
using System.Reflection;

using Android.App;
using Android.Content;
using Android.Runtime;

using Xamarin.Android.NUnitLite;

namespace Xamarin.Android.LocaleTests {

	[Instrumentation (Name="xamarin.android.localetests.TestInstrumentation")]
	public class TestInstrumentation : TestSuiteInstrumentation {

		public TestInstrumentation (IntPtr handle, JniHandleOwnership transfer)
			: base (handle, transfer)
		{
		}

		protected override void AddTests ()
		{
			AddTest (Assembly.GetExecutingAssembly ());
		}
	}
}

