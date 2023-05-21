using System.Windows.Input;
using MvvmCross.Binding.Bindings.Target;
using ObjCRuntime;
using UIKit;

namespace Anufrieva.Marria.iOS.Bindings.BarButtonItem
{
    public sealed class BarButtonItemActionBinding : MvxConvertingTargetBinding<UIBarButtonItem, ICommand>
    {
        public BarButtonItemActionBinding(UIBarButtonItem target) : base(target)
        { }

        protected override void SetValueImpl(UIBarButtonItem target, ICommand value) =>
            target.Action = Selector.FromHandle(UIAction.Create(_ => value.Execute(null)).Handle);
    }
}