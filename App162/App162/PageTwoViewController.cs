using System;
using System.Drawing;

using CoreFoundation;
using UIKit;
using Foundation;

namespace App162
{

    [Register("PageTwoViewController")]
    public class PageTwoViewController : UIViewController
    {
        public PageTwoViewController(IntPtr handle) : base(handle)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {

            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            View.BackgroundColor = UIColor.Blue;
        }
    }
}