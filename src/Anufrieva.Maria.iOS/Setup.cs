using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Ios.Core;
using Anufrieva.Marria.Core;
using Anufrieva.Marria.iOS.Bindings.BarButtonItem;
using Anufrieva.Marria.iOS.Bindings.PropertyBindings;
using Anufrieva.Marria.iOS.Bindings.SegmentControl;
using MvvmCross.Binding.Bindings.Target.Construction;
using Serilog;
using Serilog.Extensions.Logging;
using UIKit;

namespace Anufrieva.Marria.iOS
{
    public class Setup : MvxIosSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();

        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.NSLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }

        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);

            registry.RegisterFactory(new MvxCustomBindingFactory<UISegmentedControl>(
                PropertyBindings.UISegmentedControl_Segments, c => new SegmentControlSegmentsBinding(c)));
            
            registry.RegisterFactory(new MvxCustomBindingFactory<UISegmentedControl>(
                PropertyBindings.UISegmentedControl_SelectedSegment, c => new SegmentControlSelectedSegmentBinding(c)));
            
            registry.RegisterFactory(new MvxCustomBindingFactory<UIBarButtonItem>(
                PropertyBindings.UIBarButtonItem_Action, c => new BarButtonItemActionBinding(c)));
        }
    }
}
