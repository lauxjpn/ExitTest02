using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace ExitTest02.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<SomeViewModel>());
        }
    }
}
