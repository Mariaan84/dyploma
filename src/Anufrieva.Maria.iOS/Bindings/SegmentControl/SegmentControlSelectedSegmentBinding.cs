using System;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace Anufrieva.Marria.iOS.Bindings.SegmentControl
{
    public sealed class SegmentControlSelectedSegmentBinding : MvxConvertingTargetBinding<UISegmentedControl, int>
    {
        public override MvxBindingMode DefaultMode => MvxBindingMode.TwoWay;

        public SegmentControlSelectedSegmentBinding(UISegmentedControl target) : base(target)
        { }

        protected override void SetValueImpl(UISegmentedControl target, int index) => 
            target.SelectedSegment = index;

        public override void SubscribeToEvents() =>
            Target.ValueChanged += SegmentControlIndexChanged;

        private void SegmentControlIndexChanged(object sender, EventArgs e) =>
            FireValueChanged((int)Target.SelectedSegment);
    }
}