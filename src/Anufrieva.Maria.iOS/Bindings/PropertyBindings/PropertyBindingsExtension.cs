using UIKit;

namespace Anufrieva.Marria.iOS.Bindings.PropertyBindings
{
    public static class PropertyBindingsExtension
    {
        public static string BindSegments(this UISegmentedControl _) => 
            PropertyBindings.UISegmentedControl_Segments;

        public static string BindSelectedSegment(this UISegmentedControl _) =>
            PropertyBindings.UISegmentedControl_SelectedSegment;

        public static string BindAction(this UIBarButtonItem _) =>
            PropertyBindings.UIBarButtonItem_Action;
    }
}