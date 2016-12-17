using Android.Content;
using ExitTest02.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace ExitTest02.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}