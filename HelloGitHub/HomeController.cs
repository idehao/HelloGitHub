using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace HelloGitHub
{
	partial class HomeController : UIViewController
	{
		public HomeController (IntPtr handle) : base (handle)
		{
		}

		public string UserName;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			lblUser.Text = UserName;
		}
	}
}
