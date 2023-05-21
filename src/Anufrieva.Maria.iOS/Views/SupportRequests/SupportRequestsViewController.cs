using Anufrieva.Marria.Core.ViewModels.SupportRequests;
using Anufrieva.Marria.iOS.Bindings.PropertyBindings;
using Anufrieva.Marria.iOS.Cells.SupportRequest;
using Anufrieva.Marria.iOS.Styles;
using CoreGraphics;
using Foundation;
using UIKit;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;

namespace Anufrieva.Marria.iOS.Views.SupportRequests
{
    [Register(nameof(SupportRequestsViewController))]
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class SupportRequestsViewController : BaseViewController<SupportRequestsViewModel>
    {
        private UISegmentedControl _segmentedControl;
        private MvxSimpleTableViewSource _tableSource;
        private UIButton _addButton;

        public SupportRequestsViewController() : base(nameof(SupportRequestsViewController))
        { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            InitializeTable();

            SetupBindings(CreateBindingSet());
            

            void InitializeTable()
            {
                _tableSource = new MvxSimpleTableViewSource(Table, SupportRequestCell.Key, SupportRequestCell.Key);
                Table.RowHeight = 254;
                Table.Source = _tableSource;
                Table.ReloadData();
            }
        }

        protected override void SetupBindings(MvxFluentBindingDescriptionSet<IMvxIosView<SupportRequestsViewModel>,
            SupportRequestsViewModel> set)
        {
            set.Bind(_segmentedControl)
                .For(sc => sc.BindSegments())
                .To(vm => vm.Segments);

            set.Bind(_segmentedControl)
                .For(sc => PropertyBindingsExtension.BindSelectedSegment(sc))
                .To(vm => vm.SelectedSegmentIndex);

            set.Bind(_addButton)
                .For(rbbi => rbbi.BindTouchUpInside())
                .To(vm => vm.AddRequestCommandCommand);

            set.Bind(_tableSource)
                .To(vm => vm.SupportRequests);
            
            base.SetupBindings(set);
        }

        protected override void InitializeNavigationBar()
        {
            base.InitializeNavigationBar();

            _segmentedControl = CreateSegmentedControl();
            
            NavigationItem.TitleView = _segmentedControl;
            NavigationItem.RightBarButtonItem = GeneratePlusItem();
            

            UISegmentedControl CreateSegmentedControl()
            {
                var segmentedControl = new UISegmentedControl
                {
                    BackgroundColor = ColorPalette.Background.Light,
                    SelectedSegmentTintColor = ColorPalette.Transparent.LightPurple.ThirtyPercents,
                };
                
                segmentedControl.SetTitleTextAttributes(
                    new UITextAttributes
                    {
                        TextColor = ColorPalette.Text.Black, 
                        Font = UIFont.SystemFontOfSize(13, UIFontWeight.Semibold)
                    }, UIControlState.Selected);
                
                segmentedControl.SetTitleTextAttributes(new UITextAttributes
                    {
                        TextColor = ColorPalette.Text.GrayDark,
                        Font = UIFont.SystemFontOfSize(13, UIFontWeight.Medium)
                    },
                    UIControlState.Normal);

                return segmentedControl;
            }
            
            UIBarButtonItem GeneratePlusItem()
            {
                var configuration = UIButtonConfiguration.FilledButtonConfiguration;
                configuration.Background.BackgroundColor = ColorPalette.Transparent.LightPurple.ThirtyPercents;
                configuration.Background.CornerRadius = 10;
                _addButton = new UIButton { Configuration = configuration };
                _addButton.SetImage(UIImage.FromBundle("Plus"), UIControlState.Normal);
                return new UIBarButtonItem(_addButton);
            }
        }
    }
}