using System;
using System.Collections.Generic;
using System.Linq;
using Anufrieva.Marria.Core.Controls;
using MvvmCross.Binding;
using MvvmCross.Binding.Bindings.Target;
using UIKit;

namespace Anufrieva.Marria.iOS.Bindings.SegmentControl
{
    public sealed class SegmentControlSegmentsBinding : MvxConvertingTargetBinding<UISegmentedControl, 
        Segment[]>
    {
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        public SegmentControlSegmentsBinding(UISegmentedControl target) : base(target)
        { }

        protected override void SetValueImpl(UISegmentedControl target, Segment[] segments)
        {
            for (var segmentIndex = 0; segmentIndex < segments.Length; segmentIndex++)
            {
                var segment = segments[segmentIndex];
                var action = UIAction.Create(segment.Title, null, null, action => segment.Command.Execute(null));
                target.InsertSegment(action, (nuint)segmentIndex, true);
            }
        }
    }
}