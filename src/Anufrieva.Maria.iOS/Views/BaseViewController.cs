using Cirrious.FluentLayouts.Touch;
using MvvmCross.Platforms.Ios.Views;
using MvvmCross.ViewModels;
using Anufrieva.Marria.iOS.Styles;
using Foundation;
using MvvmCross.Binding.BindingContext;
using UIKit;

namespace Anufrieva.Marria.iOS.Views
{
    public abstract class BaseViewController<TViewModel> : MvxViewController<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected BaseViewController(string nibName) : base(nibName, null)
        { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View!.BackgroundColor = ColorPalette.Background.Light;
            InitializeNavigationBar();
        }

        protected virtual void SetupBindings(MvxFluentBindingDescriptionSet<IMvxIosView<TViewModel>, TViewModel> set) =>
            set.Apply();

        protected virtual void InitializeNavigationBar()
        { }
    }
}
