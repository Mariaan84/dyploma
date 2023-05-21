using System;
using UIKit;

namespace Anufrieva.Marria.iOS.Styles
{
    public static class ColorPalette
    {
        private const string NamespaceSeparator = "/";

        public static class Action
        {
            private const string ActionNamespaceTag = nameof(Action) + NamespaceSeparator;

            public static class Purple
            {
                private const string PurpleNamespaceTag = ActionNamespaceTag + nameof(Purple) + NamespaceSeparator;

                public static UIColor Dark =>
                    UIColor.FromName(PurpleNamespaceTag + nameof(Dark));
            }
        }
        
        public static class Background
        {
            private const string BackgroundNamespaceTag = nameof(Background) + NamespaceSeparator;
            
            public static UIColor Light => 
                UIColor.FromName(BackgroundNamespaceTag + nameof(Light));
            public static UIColor LightBlue =>
                UIColor.FromName(BackgroundNamespaceTag + nameof(LightBlue));
            public static UIColor SheetsAndPopUps => 
                UIColor.FromName(BackgroundNamespaceTag + "Sheets & pop-ups");
        }

        public static class Text
        {
            private const string TextNamespaceTag = nameof(Text) + NamespaceSeparator;

            public static UIColor Black =>
                UIColor.FromName(TextNamespaceTag + nameof(Black));
            
            public static UIColor Gray =>
                UIColor.FromName(TextNamespaceTag + nameof(Gray));
            
            public static UIColor GrayDark =>
                UIColor.FromName(TextNamespaceTag + "Gray (Dark)");
        }

        public static class Transparent
        {
            private const string TransparentNamespaceTag = nameof(Transparent) + NamespaceSeparator;
            public static class LightPurple
            {
                private const string LightPurpleNamespaceTag =
                    TransparentNamespaceTag + "Light purple" + NamespaceSeparator;

                public static UIColor SixPercents => 
                    UIColor.FromName(LightPurpleNamespaceTag + "6%");

                public static UIColor ThirtyPercents =>
                    UIColor.FromName(LightPurpleNamespaceTag + "30%");
            }
        }
    }
}
