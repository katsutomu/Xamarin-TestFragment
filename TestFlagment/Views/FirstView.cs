using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Droid.Fragging;

namespace TestFlagment.Views
{
    [Activity(Label = "View for FirstViewModel")]
	public class FirstView : MvxFragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
		
			var fragment = (DetailFragment)SupportFragmentManager.FindFragmentById(Resource.Id.detail_fragment);
			fragment.ViewModel = ViewModel;
		}
    }
}