
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
using Cirrious.MvvmCross.Droid.Views;
using Android.Support.Design.Widget;

namespace TestFlagment
{
	[Activity (Label = "HomeTabActivity")]			
	public class TabView : MvxFragmentActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.TabView);
			var tabLayout = FindViewById<TabLayout> (Resource.Id.tab_layout);
			tabLayout.AddTab ( tabLayout.NewTab().SetText("a"));
			tabLayout.AddTab ( tabLayout.NewTab().SetText("b"));
			tabLayout.AddTab ( tabLayout.NewTab().SetText("c"));
		}
	}
}

