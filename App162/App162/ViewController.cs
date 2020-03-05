using Foundation;
using System;
using UIKit;

namespace App162
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

        partial void UIButton1422_TouchUpInside(UIButton sender)
        {
            var storyboard = UIStoryboard.FromName("Main", null);
            var viewController = storyboard.InstantiateViewController("PageTwoVC"); // Your view controller here
            UIApplication.SharedApplication.KeyWindow.RootViewController = viewController;
        }
    }
}