
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cirrious.MvvmCross.Droid.Fragging;

namespace TestFlagment
{
	[Activity (Label = "HomeTabActivity")]			
	public class HomeTabActivity : MvxTabsFragmentActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Create your application here
		}

		public TabView()
			: base(Resource.Layout.Page_TabView, Resource.Id.actualtabcontent)
		{
		}
	}
}

