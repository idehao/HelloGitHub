using System;

using UIKit;

namespace HelloGitHub
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void BtnLogin_TouchUpInside (UIButton sender)
		{
			// NOTE: "HomeController" is the name of the controller that we wish to navigate to
			// "home" is the Storyboard ID
			HomeController controller = this.Storyboard.InstantiateViewController("home") as HomeController;
			// TODO: add code to pass a value to the HomeController
			controller.UserName = txtUser.Text;

			this.NavigationController.PushViewController(controller, true);
		}
	}
}

