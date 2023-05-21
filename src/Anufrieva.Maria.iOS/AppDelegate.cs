using Foundation;
using MvvmCross.Platforms.Ios.Core;
using Anufrieva.Marria.Core;
using Anufrieva.Marria.iOS.Styles;
using UIKit;

namespace Anufrieva.Marria.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);
            
            var appearance = new UINavigationBarAppearance();
            appearance.ConfigureWithOpaqueBackground();
            appearance.BackgroundColor = ColorPalette.Background.LightBlue;
            appearance.TitleTextAttributes = new UIStringAttributes(new NSMutableDictionary
                { {UIStringAttributeKey.ForegroundColor, ColorPalette.Text.Black} });
            var proxy = UINavigationBar.Appearance;
            proxy.TintColor = ColorPalette.Text.Black;
            proxy.BarTintColor = ColorPalette.Text.Black;
            proxy.StandardAppearance = appearance;
            proxy.ScrollEdgeAppearance = proxy.StandardAppearance;

            return result;
        }
    }
}
