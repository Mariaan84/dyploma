// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Anufrieva.Marria.iOS.Views.AddSupportRequest
{
	partial class AddSupportRequestViewController
	{
		[Outlet]
		UIKit.UITextView DescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIButton PostButton { get; set; }

		[Outlet]
		UIKit.UITextField TitleLabel { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (DescriptionLabel != null) {
				DescriptionLabel.Dispose ();
				DescriptionLabel = null;
			}

			if (PostButton != null) {
				PostButton.Dispose ();
				PostButton = null;
			}

		}
	}
}
