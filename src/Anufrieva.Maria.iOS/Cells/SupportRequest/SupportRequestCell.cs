using System;
using System.Collections.Generic;
using System.ComponentModel;
using Anufrieva.Marria.iOS.Styles;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding;
using MvvmCross.Platforms.Ios.Binding.Views;
using SupportRequestModel = Anufrieva.Marria.Core.Models.SupportRequest;
using UIKit;
using DateTimeConverter = Anufrieva.Marria.iOS.Converters.DateTimeConverter;

namespace Anufrieva.Marria.iOS.Cells.SupportRequest
{
    [Register(nameof(SupportRequestCell))]
    public partial class SupportRequestCell : MvxTableViewCell
    {
        public static readonly string Key = new NSString(nameof(SupportRequestCell));
        public static UINib Nib;
        
        public SupportRequestCell()
        {
            Nib = UINib.FromName(nameof(SupportRequestCell), NSBundle.MainBundle);
        }

        public SupportRequestCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                var set = this.CreateBindingSet<SupportRequestCell, SupportRequestModel>();

                set.Bind(Title).To(m => m.Title);
                set.Bind(Date).To(m => m.Date).WithConversion<DateTimeConverter>();
                set.Bind(Description).To(m => m.Description);
                set.Bind(Name).To(m => m.User.Name);
                set.Bind(Age).To(m => m.User.Age);
                set.Bind(Location).For(v => v.BindTitle()).To(m => m.User.City);
                set.Bind(Save).For(v => v.TintColor).To(m => m.Saved)
                    .WithDictionaryConversion(new Dictionary<bool, UIColor>
                    { 
                        { true, ColorPalette.Action.Purple.Dark },
                        { false, ColorPalette.Text.Black }
                    });

                set.Bind(SendMessage).To(m => m.SendMessageCommand);
                set.Bind(Save).To(m => m.ChangeSavedCommand);
                
                set.Apply();
            });
        }
    }
}