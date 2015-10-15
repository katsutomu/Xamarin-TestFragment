using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Droid.Fragging;
using Android.Support.V4.App;
using Core;
using Cirrious.MvvmCross.ViewModels;

namespace TestFlagment.Views
{
    [Activity(Label = "View for FirstViewModel")]
	public class FirstView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
			var viewPager = FindViewById<ViewPager> (Resource.Id.view_pager);
			viewPager.Adapter = new TestPagerAdapter (SupportFragmentManager);
		}

		public class TestPagerAdapter : FragmentStatePagerAdapter
		{
			Android.Support.V4.App.Fragment[] fragments = new Android.Support.V4.App.Fragment[] {
				new DetailFragment() {
					ViewModel = new DetailViewModel()
				},
				new DetailFragment(){
					ViewModel =  new SubViewModel()
				}
			};
			public TestPagerAdapter (Android.Support.V4.App.FragmentManager fm) : base(fm)
			{
			}

			#region implemented abstract members of PagerAdapter
			public override int Count {
				get {
					return fragments.Length;
				}
			}
			#endregion
			#region implemented abstract members of FragmentStatePagerAdapter
			public override Android.Support.V4.App.Fragment GetItem (int position)
			{
				return fragments[position];
			}
			#endregion
		}
    }

}