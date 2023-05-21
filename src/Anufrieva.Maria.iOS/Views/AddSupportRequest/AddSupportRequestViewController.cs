using System;
using System.Collections.Generic;
using Anufrieva.Marria.Core.ViewModels.AddSupportRequest;
using Anufrieva.Marria.Core.ViewModels.SupportRequests;
using Anufrieva.Marria.iOS.Converters;
using Anufrieva.Marria.iOS.Styles;
using UIKit;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Views;

namespace Anufrieva.Marria.iOS.Views.AddSupportRequest
{
    [Register(nameof(AddSupportRequestViewController))]
    public partial class AddSupportRequestViewController : BaseViewController<AddSupportRequestViewModel>
    {
        public AddSupportRequestViewController() : base(nameof(AddSupportRequestViewController))
        { }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "New request";

            SetupBindings(CreateBindingSet());
        }

        protected override void SetupBindings(MvxFluentBindingDescriptionSet<IMvxIosView<AddSupportRequestViewModel>,
            AddSupportRequestViewModel> set)
        {
            set.Bind(TitleLabel)
                .To(vm => vm.NewRequest.Title);

            set.Bind(DescriptionLabel)
                .For(v => v.BindText())
                .To(vm => vm.NewRequest.Description);
            
            set.Bind(PostButton)
                .To(vm => vm.PostCommand);

            base.SetupBindings(set);
        }
    }
}