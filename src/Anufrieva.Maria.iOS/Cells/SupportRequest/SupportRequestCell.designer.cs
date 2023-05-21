// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Anufrieva.Marria.iOS.Cells.SupportRequest
{
	partial class SupportRequestCell
	{
		[Outlet]
		UIKit.UILabel Age { get; set; }

		[Outlet]
		UIKit.UIImageView Avatar { get; set; }

		[Outlet]
		UIKit.UILabel Date { get; set; }

		[Outlet]
		UIKit.UILabel Description { get; set; }

		[Outlet]
		UIKit.UIButton Location { get; set; }

		[Outlet]
		UIKit.UILabel Name { get; set; }

		[Outlet]
		UIKit.UIButton Save { get; set; }

		[Outlet]
		UIKit.UIButton SendMessage { get; set; }

		[Outlet]
		UIKit.UILabel Title { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (Title != null) {
				Title.Dispose ();
				Title = null;
			}

			if (Date != null) {
				Date.Dispose ();
				Date = null;
			}

			if (Description != null) {
				Description.Dispose ();
				Description = null;
			}

			if (Avatar != null) {
				Avatar.Dispose ();
				Avatar = null;
			}

			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

			if (Age != null) {
				Age.Dispose ();
				Age = null;
			}

			if (Location != null) {
				Location.Dispose ();
				Location = null;
			}

			if (SendMessage != null) {
				SendMessage.Dispose ();
				SendMessage = null;
			}

			if (Save != null) {
				Save.Dispose ();
				Save = null;
			}

		}
	}
}
